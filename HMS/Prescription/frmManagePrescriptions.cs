using HMS.Appointment;
using HMS.BLL;
using HMS.Medical_Visit;
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

namespace HMS.Prescription
{
    public partial class frmManagePrescriptions : JOSubForm
    {
        bool IsFiltered = false, IsLoading = false;
        bool IsDepartmentsLoading = false, IsSpecializationsLoading = false;
        int CurrentPage = 0, NextPage = 1, PageSize = 15, FirstRow = 0, RowsCount = 0;

        DataTable dtPrescriptions = new DataTable(), dtPage;

        public frmManagePrescriptions()
        {
            InitializeComponent();
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            await LoadFirstPage();
        }

        private void dgvPrescriptions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvPrescriptions.Columns["Status"].Index && e.Value != null)
            {
                if (e.Value.ToString() == "Active")
                {
                    //e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if (e.Value.ToString() == "Expired")
                {
                    //e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
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
                    IsFiltered = true;
                    cbStatus.Visible = false;
                    tbFilter.Visible = true;

                    tbFilter.AllowLetters = tbFilter.AllowSpecialCharacters = false;
                    tbFilter.AllowDigits = true;
                    break;
                case "Medical Visit ID":
                    IsFiltered = true;
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

        private string GetFilter()
        {
            switch(cbFilter.Text.Trim())
            {
                case "Medical Visit ID":
                    return "MedicalVisitID";
                default:
                    return tbFilter.Text.Trim();
            }
        }

        private async Task<int> GetFilteredRowsCount()
        {
            if (cbFilter.Text == "Status")
                return await clsPrescription.GetCountByFilter("Status", cbStatus.Text.Trim() == "Active" ? $"{(byte?)clsPrescription.enStatus.Active}" : $"{(byte?)clsPrescription.enStatus.Expired}");
            else
                return await clsPrescription.GetCountByFilter(GetFilter(), tbFilter.Text);
        }

        private async Task<DataTable> GetFilteredDataPage(int Page)
        {
            if (cbFilter.Text == "Status")
                return await clsPrescription.GetPageByFilter(Page, PageSize, "Status", cbStatus.Text.Trim() == "Active" ? $"{(byte?)clsPrescription.enStatus.Active}" : $"{(byte?)clsPrescription.enStatus.Expired}");
            else
                return await clsPrescription.GetPageByFilter(Page, PageSize, GetFilter(), tbFilter.Text);
        }

        private async void cbActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsFiltered = (cbStatus.Text != "All");
            await LoadFirstPage();
        }

        private void showDetailstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmPrescriptionDetails(Convert.ToInt32(dgvPrescriptions.SelectedRows[0]?.Cells["ID"]?.Value)).ShowDialog();
        }

        private async void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddNewEditPrescription().ShowDialog();
            RowsCount = IsFiltered ? await GetFilteredRowsCount() : await clsPrescription.GetCount();

            lblRowCount.Text = $"#{RowsCount}";
        }

        private void edittoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddNewEditPrescription(Convert.ToInt32(dgvPrescriptions.SelectedRows[0]?.Cells["ID"]?.Value)).ShowDialog();
        }

        private async Task LoadNextPage()
        {
            IsLoading = true;

            FirstRow = dgvPrescriptions.FirstDisplayedScrollingRowIndex;

            NextPage = CurrentPage + 1;

            dtPage = IsFiltered ? await GetFilteredDataPage(NextPage) : await clsPrescription.GetPage(NextPage, PageSize);

            if (dtPage.Rows.Count > 0)
            {
                dtPrescriptions.Merge(dtPage);

                CurrentPage++;

                if (FirstRow >= 0)
                    dgvPrescriptions.FirstDisplayedScrollingRowIndex = FirstRow;
            }
            else
                MessageBox.Show("Failed to load data", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

            IsLoading = false;
        }

        private async Task LoadFirstPage()
        {
            dtPrescriptions.Clear();
            CurrentPage = 0;

            RowsCount = IsFiltered ? await GetFilteredRowsCount() : await clsPrescription.GetCount();

            lblRowCount.Text = $"#{RowsCount}";

            if (RowsCount > 0)
                await LoadNextPage();
            else
                dtPrescriptions.Clear();
        }

        private async void frmManagePrescriptions_Load(object sender, EventArgs e)
        {
            dgvPrescriptions.DataSource = dtPrescriptions;

            await LoadFirstPage();

            if (dgvPrescriptions.Columns?.Count > 0)
            {
                foreach (DataGridViewColumn column in dgvPrescriptions.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                //dgvPrescriptions.Columns["PatientID"].Visible = false;
            }
        }

        private async void dgvPrescriptions_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                if (dtPrescriptions.Rows.Count < RowsCount)
                {
                    if (dgvPrescriptions.FirstDisplayedScrollingRowIndex + dgvPrescriptions.DisplayedRowCount(false) >= dgvPrescriptions.RowCount - 5)
                    {
                        if (!IsLoading)
                            await LoadNextPage();
                    }
                }
            }
        }
    }
}
