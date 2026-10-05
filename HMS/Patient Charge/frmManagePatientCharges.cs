using HMS.Appointment;
using HMS.BLL;
using HMS.Payment;
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

namespace HMS.Patient_Charge
{
    public partial class frmManagePatientCharges : JOSubForm
    {
        string StatusCellValue;
        bool IsFiltered = false, IsLoading = false;
        bool IsStatusesLoading = false;
        int CurrentPage = 0, NextPage = 1, PageSize = 15, FirstRow = 0, RowsCount = 0;

        DataTable dtPatientCharges = new DataTable(), dtPage;

        public frmManagePatientCharges()
        {
            InitializeComponent();
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            await LoadFirstPage();
        }

        private void dgvPatientCharges_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvPatientCharges.Columns?["Status"]?.Index && e.Value != null)
            {
                if (e.Value.ToString() == "Unpaid")
                {
                    e.CellStyle.ForeColor = Color.Firebrick;
                }
                else if (e.Value.ToString() == "Partially Paid")
                {
                    e.CellStyle.ForeColor = Color.DarkOrange;
                }
                else if (e.Value.ToString() == "Paid")
                {
                    e.CellStyle.ForeColor = Color.ForestGreen;
                }
                else if (e.Value.ToString() == "Cancelled")
                {
                    e.CellStyle.ForeColor = Color.Gray;
                }
            }
        }

        private async void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsFiltered = (cbStatus.Text != "All");
            await LoadFirstPage();
        }

        private async void tbFilter_TextChanged(object sender, EventArgs e)
        {
            IsFiltered = (!string.IsNullOrEmpty(tbFilter.Text));
            await LoadFirstPage();
        }

        private async void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFilter.Text)
            {
                case "None":
                    IsFiltered = false;
                    tbFilter.Visible = cbStatus.Visible = false;
                    tbFilter.Text = string.Empty;
                    await LoadFirstPage();
                    break;
                case "ID":
                    IsFiltered = false;
                    cbStatus.Visible = false;
                    tbFilter.Visible = true;

                    tbFilter.AllowLetters = tbFilter.AllowSpecialCharacters = false;
                    tbFilter.AllowDigits = true;
                    break;
                case "Appointment ID":
                    IsFiltered = false;
                    cbStatus.Visible = false;
                    tbFilter.Visible = true;

                    tbFilter.AllowLetters = tbFilter.AllowSpecialCharacters = false;
                    tbFilter.AllowDigits = true;
                    break;
                case "Status":
                    tbFilter.Visible = false;
                    tbFilter.Text = string.Empty;
                    cbStatus.Visible = true;
                    cbStatus.Text = "All";
                    break;
            }

            if (tbFilter.Visible)
                tbFilter.Focus();
            else if (cbStatus.Visible)
                cbStatus.Focus();
        }

        private async Task<int> GetFilteredRowsCount()
        {
            if (cbFilter.Text == "ID")
                return await clsPatientCharge.GetCountByFilter("ID", tbFilter.Text.Trim());
            else if (cbFilter.Text == "Appointment ID")
                return await clsPatientCharge.GetCountByFilter("AppointmentID", tbFilter.Text.Trim());
            else
                return await clsPatientCharge.GetCountByFilter("Status", Convert.ToByte(cbStatus.SelectedItem).ToString());
        }

        private async Task<DataTable> GetFilteredDataPage(int Page)
        {
            if (cbFilter.Text == "ID")
                return await clsPatientCharge.GetPageByFilter(Page, PageSize, "ID", tbFilter.Text.Trim());
            else if (cbFilter.Text == "Appointment ID")
                return await clsPatientCharge.GetPageByFilter(Page, PageSize, "AppointmentID", tbFilter.Text.Trim());
            else
                return await clsPatientCharge.GetPageByFilter(Page, PageSize, "Status", Convert.ToByte(cbStatus.SelectedItem).ToString());
        }

        private void showDetailstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmPatientChargeDetails(Convert.ToInt32(dgvPatientCharges.SelectedRows[0]?.Cells["ID"]?.Value)).ShowDialog();
        }

        private async void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddNewEditPatientCharge().ShowDialog();
            RowsCount = IsFiltered ? await GetFilteredRowsCount() : await clsPatientCharge.GetCount();
            lblRowCount.Text = $"#{RowsCount}";
        }

        private async void performpaymenttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewEditPayment frm = new frmAddNewEditPayment();
            await frm.LoadPatientCharge(Convert.ToInt32(dgvPatientCharges.SelectedRows[0]?.Cells["ID"]?.Value));
            frm.ShowDialog();
        }

        private async void CanceltoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel this patient charge?\nAll payments will be refunded.", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                decimal? RefundAmount = await clsPatientCharge.Cancel(Convert.ToInt32(dgvPatientCharges.SelectedRows[0]?.Cells["ID"]?.Value));
                if (RefundAmount.HasValue)
                {
                    MessageBox.Show($"Patient charge cancelled successfully.\nRefund amount: {RefundAmount.Value}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to cancel the patient charge.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmsPatientCharges_Opening(object sender, CancelEventArgs e)
        {
            if (dgvPatientCharges.SelectedRows.Count > 0)
            {
                StatusCellValue = dgvPatientCharges.SelectedRows[0].Cells["Status"].Value.ToString();
                showDetailstoolStripMenuItem.Enabled = true;

                performpaymenttoolStripMenuItem.Enabled = CanceltoolStripMenuItem.Enabled = true;
                if (StatusCellValue == "Cancelled")
                {
                    performpaymenttoolStripMenuItem.Enabled = CanceltoolStripMenuItem.Enabled = false;
                }
                else if (StatusCellValue == "Paid")
                {
                    performpaymenttoolStripMenuItem.Enabled = false;
                }
            }
        }

        private void PaymentsHistorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaymentsHistory frm = new frmPaymentsHistory(Convert.ToInt32(dgvPatientCharges.SelectedRows[0]?.Cells["ID"]?.Value), (clsPatientCharge.enStatus)Convert.ToByte(dgvPatientCharges.SelectedRows[0]?.Cells["StatusNum"]?.Value));
            frm.ShowDialog();
        }

        private void DeletetoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async Task LoadNextPage()
        {
            IsLoading = true;

            FirstRow = dgvPatientCharges.FirstDisplayedScrollingRowIndex;

            NextPage = CurrentPage + 1;

            dtPage = IsFiltered ? await GetFilteredDataPage(NextPage) : await clsPatientCharge.GetPage(NextPage, PageSize);

            if (dtPage.Rows.Count > 0)
            {
                dtPatientCharges.Merge(dtPage);

                CurrentPage++;

                if (FirstRow >= 0)
                    dgvPatientCharges.FirstDisplayedScrollingRowIndex = FirstRow;
            }
            else
                MessageBox.Show("Failed to load data", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

            IsLoading = false;
        }

        private async Task LoadFirstPage()
        {
            dtPatientCharges.Clear();
            CurrentPage = 0;

            RowsCount = IsFiltered ? await GetFilteredRowsCount() : await clsPatientCharge.GetCount();

            lblRowCount.Text = $"#{RowsCount}";

            if (RowsCount > 0)
                await LoadNextPage();
            else
                dtPatientCharges.Clear();
        }

        private void LoadStatuses()
        {
            IsStatusesLoading = true;
            cbStatus.Items.Add("All");

            foreach (clsPatientCharge.enStatus mode in Enum.GetValues(typeof(clsPatientCharge.enStatus)))
                cbStatus.Items.Add(mode);

            IsStatusesLoading = false;
        }

        private async void frmManagePatientCharges_Load(object sender, EventArgs e)
        {
            dgvPatientCharges.DataSource = dtPatientCharges;

            await LoadFirstPage();

            if (dgvPatientCharges.Columns?.Count > 0)
            {
                foreach (DataGridViewColumn column in dgvPatientCharges.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                dgvPatientCharges.Columns["StatusNum"].Visible = false;
            }


            LoadStatuses();
        }

        private async void dgvPatientCharges_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                if (dtPatientCharges.Rows.Count < RowsCount)
                {
                    if (dgvPatientCharges.FirstDisplayedScrollingRowIndex + dgvPatientCharges.DisplayedRowCount(false) >= dgvPatientCharges.RowCount - 5)
                    {
                        if (!IsLoading)
                            await LoadNextPage();
                    }
                }
            }
        }
    }
}