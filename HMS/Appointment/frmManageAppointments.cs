using Common;
using HMS.Appointment;
using HMS.BLL;
using HMS.Patient_Charge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Youssef.WinForms.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS.Appointment
{
    public partial class frmManageAppointments : JOSubForm
    {
        bool IsFiltered = false, IsLoading = false, IsAppointmentStatusesLoading = false, IsAppointmentTypesLoading = false;
        int CurrentPage = 0, NextPage = 1, PageSize = 15, FirstRow = 0, RowsCount = 0;
        string StatusCellValue;

        DataTable dtAppointments = new DataTable(), dtPage;

        public frmManageAppointments()
        {
            InitializeComponent();
        }

        private void showDetailstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAppointmentDetails frm = new frmAppointmentDetails(Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["ID"]?.Value));
            frm.ShowDialog();
        }

        private async void schedulenewappointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewEditAppointment frm = new frmAddNewEditAppointment();
            frm.ShowDialog();
            RowsCount = IsFiltered ? await GetFilteredRowsCount() : await clsAppointment.GetCount();

            lblRowCount.Text = $"#{RowsCount}";
        }

        private async void CheckIntoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewEditPatientCharge frm = new frmAddNewEditPatientCharge();
            await frm.LoadAppointmentDate(Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["ID"]?.Value));
            frm.ShowDialog();
        }

        private async void rescheduletoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewEditAppointment frm = new frmAddNewEditAppointment(Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["ID"].Value));
            frm.ShowDialog();
            RowsCount = IsFiltered ? await GetFilteredRowsCount() : await clsAppointment.GetCount();

            lblRowCount.Text = $"#{RowsCount}";
        }

        private async void canceltoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel this appointment?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (await clsAppointment.Cancel(Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["ID"].Value)))
                    MessageBox.Show("Appointment cancelled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed to cancel the appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void patienthistorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatientAppointmentsHistory frm = new frmPatientAppointmentsHistory(Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["PatientID"].Value));
            frm.ShowDialog();
            RowsCount = IsFiltered ? await GetFilteredRowsCount() : await clsAppointment.GetCount();

            lblRowCount.Text = $"#{RowsCount}";
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            await LoadFirstPage();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            IsFiltered = dtpDate.Visible && btnSearch.Visible;
            await LoadFirstPage();
        }

        private string GetFilter()
        {
            switch (cbFilter.Text)
            {
                case "ID":
                    return "AppointmentID";
                case "Medical Record No":
                    return "MedicalRecordNo";
                default:
                    return cbFilter.Text;
            }
        }

        private async Task<int> GetFilteredRowsCount()
        {
            if (cbFilter.Text == "Day")
                return await clsAppointment.GetCountByFilter("Day", cbDaysOfWeek.Text.Trim());
            else if (cbFilter.Text == "Type")
                return await clsAppointment.GetCountByFilter("Type", cbTypes.Text.Trim());
            else if (cbFilter.Text == "Status")
                return await clsAppointment.GetCountByFilter("Status", cbStatuses.Text.Trim());
            else if (cbFilter.Text == "Date")
                return await clsAppointment.GetCountByFilter("Date", clsUtility.DateFormat(dtpDate.Value).Trim());
            else
                return await clsAppointment.GetCountByFilter(GetFilter().Trim(), tbFilter.Text);
        }

        private async Task<DataTable> GetFilteredDataPage(int Page)
        {
            if (cbFilter.Text == "Day")
                return await clsAppointment.GetPageByFilter(Page, PageSize, "Day", cbDaysOfWeek.Text.Trim());
            else if (cbFilter.Text == "Type")
                return await clsAppointment.GetPageByFilter(Page, PageSize, "Type", cbTypes.Text.Trim());
            else if (cbFilter.Text == "Status")
                return await clsAppointment.GetPageByFilter(Page, PageSize, "Status", cbStatuses.Text.Trim());
            else if (cbFilter.Text == "Date")
                return await clsAppointment.GetPageByFilter(Page, PageSize, "Date", clsUtility.DateFormat(dtpDate.Value).Trim());
            else
                return await clsAppointment.GetPageByFilter(Page, PageSize, GetFilter().Trim(), tbFilter.Text);
        }

        private async Task LoadNextPage()
        {
            IsLoading = true;

            FirstRow = dgvAppointments.FirstDisplayedScrollingRowIndex;

            NextPage = CurrentPage + 1;

            dtPage = IsFiltered ? await GetFilteredDataPage(NextPage) : await clsAppointment.GetPage(NextPage, PageSize);

            if (dtPage.Rows.Count > 0)
            {
                dtAppointments.Merge(dtPage);

                CurrentPage = NextPage;

                if (FirstRow >= 0)
                    dgvAppointments.FirstDisplayedScrollingRowIndex = FirstRow;
            }
            else
                MessageBox.Show("Failed to load data", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

            IsLoading = false;
        }

        private async Task LoadFirstPage()
        {
            dtAppointments.Clear();
            CurrentPage = 0;

            RowsCount = IsFiltered ? await GetFilteredRowsCount() : await clsAppointment.GetCount();

            lblRowCount.Text = $"#{RowsCount}";

            if (RowsCount > 0)
                await LoadNextPage();
            else
                dtAppointments.Clear();
        }

        private async void tbFilter_TextChanged(object sender, EventArgs e)
        {
            IsFiltered = (!string.IsNullOrEmpty(tbFilter.Text));
            await LoadFirstPage();
        }

        private void cmsAppointments_Opening(object sender, CancelEventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count > 0)
            {
                StatusCellValue = dgvAppointments.SelectedRows[0].Cells["Status"].Value.ToString();

                showDetailstoolStripMenuItem.Enabled = true;

                if (StatusCellValue == "Completed")
                {
                    makevisitedtoolStripMenuItem.Enabled =
                    rescheduletoolStripMenuItem.Enabled =
                    canceltoolStripMenuItem.Enabled = false;
                }
                else if (StatusCellValue == "No Show")
                {
                    makevisitedtoolStripMenuItem.Enabled =
                    canceltoolStripMenuItem.Enabled = false;

                    rescheduletoolStripMenuItem.Enabled = true;
                }
                else if (StatusCellValue == "Cancelled")
                {
                    makevisitedtoolStripMenuItem.Enabled =
                    rescheduletoolStripMenuItem.Enabled =
                    canceltoolStripMenuItem.Enabled = false;
                }
                else if (StatusCellValue == "Scheduled")
                {
                    makevisitedtoolStripMenuItem.Enabled =
                    rescheduletoolStripMenuItem.Enabled =
                    canceltoolStripMenuItem.Enabled = true;
                }
                else if (StatusCellValue == "Waiting")
                {
                    makevisitedtoolStripMenuItem.Enabled = false;
                    rescheduletoolStripMenuItem.Enabled = false;
                    canceltoolStripMenuItem.Enabled = true;
                }
            }
        }

        private async void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(IsAppointmentStatusesLoading || IsAppointmentTypesLoading))
            {
                System.Windows.Forms.Control cb = (System.Windows.Forms.Control)sender;
                IsFiltered = cb.Text != "All";
                await LoadFirstPage();
            }
        }

        private async void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsFiltered = false;

            switch (cbFilter.Text)
            {
                case "None":
                    tbFilter.Visible = dtpDate.Visible = btnSearch.Visible = cbDaysOfWeek.Visible = cbTypes.Visible = cbStatuses.Visible = false;
                    tbFilter.Text = string.Empty;
                    await LoadFirstPage();
                    break;
                case "ID":
                    cbDaysOfWeek.Visible = dtpDate.Visible = btnSearch.Visible = cbTypes.Visible = cbStatuses.Visible = false;
                    tbFilter.Visible = true;

                    tbFilter.AllowLetters = tbFilter.AllowSpecialCharacters = false;
                    tbFilter.AllowDigits = true;
                    break;
                case "Medical Record No":
                    cbDaysOfWeek.Visible = dtpDate.Visible = btnSearch.Visible = cbTypes.Visible = cbStatuses.Visible = false;
                    tbFilter.Visible = true;

                    tbFilter.AllowSpecialCharacters = false;
                    tbFilter.AllowLetters = tbFilter.AllowDigits = true;
                    break;
                case "Date":
                    tbFilter.Visible = cbDaysOfWeek.Visible = cbTypes.Visible = cbStatuses.Visible = false;

                    dtpDate.Visible = btnSearch.Visible = true;
                    break;
                case "Day":
                    tbFilter.Visible = dtpDate.Visible = btnSearch.Visible = cbTypes.Visible = cbStatuses.Visible = false;
                    tbFilter.Text = string.Empty;
                    cbDaysOfWeek.Visible = true;
                    cbDaysOfWeek.Text = "All";
                    break;
                case "Type":
                    tbFilter.Visible = dtpDate.Visible = btnSearch.Visible = cbDaysOfWeek.Visible = cbStatuses.Visible = false;
                    tbFilter.Text = string.Empty;
                    cbTypes.Visible = true;
                    cbTypes.Text = "All";
                    break;
                case "Status":
                    tbFilter.Visible = dtpDate.Visible = btnSearch.Visible = cbDaysOfWeek.Visible = cbTypes.Visible = false;
                    tbFilter.Text = string.Empty;
                    cbStatuses.Visible = true;
                    cbStatuses.Text = "All";
                    break;
            }

            if (tbFilter.Visible)
                tbFilter.Focus();
            else if (cbDaysOfWeek.Visible)
                cbDaysOfWeek.Focus();
            else if (cbStatuses.Visible)
                cbStatuses.Focus();
            else if (cbTypes.Visible)
                cbTypes.Focus();
            else if (dtpDate.Visible && btnSearch.Visible)
                btnSearch.Focus();
        }

        private void dgvAppointments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvAppointments.Columns["Status"].Index && e.Value != null)
            {
                if (e.Value.ToString() == "Scheduled")
                {
                    //e.CellStyle.BackColor = Color.DodgerBlue;
                    e.CellStyle.ForeColor = Color.DodgerBlue;
                }
                else if (e.Value.ToString() == "Waiting")
                {
                    //e.CellStyle.BackColor = Color.DarkOrange;
                    e.CellStyle.ForeColor = Color.DarkOrange;
                }
                else if (e.Value.ToString() == "Completed")
                {
                    //e.CellStyle.BackColor = Color.ForestGreen;
                    e.CellStyle.ForeColor = Color.ForestGreen;
                }
                else if (e.Value.ToString() == "Cancelled")
                {
                    //e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.Red;
                }
                else if (e.Value.ToString() == "No Show")
                {
                    //e.CellStyle.BackColor = Color.DimGray;
                    e.CellStyle.ForeColor = Color.DimGray;
                }
            }
        }

        private async void dgvAppointments_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                if (dtAppointments.Rows.Count < RowsCount)
                {
                    if (dgvAppointments.FirstDisplayedScrollingRowIndex + dgvAppointments.DisplayedRowCount(false) >= dgvAppointments.RowCount - 5)
                    {
                        if (!IsLoading)
                            await LoadNextPage();
                    }
                }
            }
        }

        private void LoadAppointmentStatuses()
        {
            IsAppointmentStatusesLoading = true;
            List<string> lAppointmentStatuses = new List<string>();

            lAppointmentStatuses.Add("All");
            foreach (clsAppointment.enStatus Status in Enum.GetValues(typeof(clsAppointment.enStatus)))
                lAppointmentStatuses.Add(Status.ToString() == "NoShow" ? "No Show" : Status.ToString());

            cbStatuses.DataSource = lAppointmentStatuses;
            IsAppointmentStatusesLoading = false;
        }

        private void LoadAppointmentTypes()
        {
            IsAppointmentTypesLoading = true;
            List<string> lAppointmentTypees = new List<string>();

            lAppointmentTypees.Add("All");
            foreach (clsAppointment.enType Type in Enum.GetValues(typeof(clsAppointment.enType)))
                lAppointmentTypees.Add(Type.ToString());

            cbTypes.DataSource = lAppointmentTypees;
            IsAppointmentTypesLoading = false;
        }

        private async void frmManageAppointments_Load(object sender, EventArgs e)
        {
            dtpDate.CustomFormat = "dddd dd/MM/yyyy";

            LoadAppointmentStatuses();
            LoadAppointmentTypes();

            dgvAppointments.DataSource = dtAppointments;
            await LoadFirstPage();

            if (dgvAppointments.Columns?.Count > 0)
            {
                foreach (DataGridViewColumn column in dgvAppointments.Columns)
                {
                    //column.Visible = (column.Name != "PatientID");
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                dgvAppointments.Columns["PatientID"].Visible = false;
            }
        }
    }
}
