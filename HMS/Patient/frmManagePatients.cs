using HMS.Appointment;
using HMS.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Youssef.WinForms.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS.Patients
{
    public partial class frmManagePatients : JOSubForm
    {
        bool IsFiltered = false, IsLoading = false;
        int CurrentPage = 0, NextPage = 1, PageSize = 15, FirstRow = 0, RowsCount = 0;

        DataTable dtPatients = new DataTable(), dtPage;

        public frmManagePatients()
        {
            InitializeComponent();
        }

        private async void tbFilter_TextChanged(object sender, EventArgs e)
        {
            IsFiltered = (!string.IsNullOrEmpty(tbFilter.Text));
            await LoadFirstPage();
        }

        private async void cbBloodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsFiltered = (cbBloodType.Text != "All");
            await LoadFirstPage();
        }

        private async void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsFiltered = (cbGender.Text != "All");
            await LoadFirstPage();
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            await LoadFirstPage();
        }

        private void showDetailstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatientDetails frm = new frmPatientDetails(Convert.ToInt32(dgvPatients.SelectedRows[0].Cells["ID"].Value));
            frm.ShowDialog();
        }

        private async void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmAddNewEditPatient()).ShowDialog();
            RowsCount = IsFiltered ? await GetFilteredRowsCount() : await clsPatient.GetCount();

            lblRowCount.Text = $"#{RowsCount}";
        }

        private void edittoolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmAddNewEditPatient(Convert.ToInt32(dgvPatients.SelectedRows[0].Cells["ID"].Value))).ShowDialog();
        }

        private async void patienthistorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatientAppointmentsHistory frm = new frmPatientAppointmentsHistory(Convert.ToInt32(dgvPatients.SelectedRows[0].Cells["ID"].Value));
            frm.ShowDialog();
        }

        private async Task<int> GetFilteredRowsCount()
        {
            if (cbFilter.Text == "Gender")
                return await clsPatient.GetCountByFilter("Gender", cbGender.Text.Trim());
            else if (cbFilter.Text == "Blood Type")
                return await clsPatient.GetCountByFilter("Blood Type", cbBloodType.Text.Trim());
            else
                return await clsPatient.GetCountByFilter(cbFilter.Text.Trim(), tbFilter.Text);
        }

        private async Task<DataTable> GetFilteredDataPage(int Page)
        {
            if (cbFilter.Text == "Gender")
                return await clsPatient.GetPageByFilter(Page, PageSize, "Gender", cbGender.Text.Trim());
            else if (cbFilter.Text == "Blood Type")
                return await clsPatient.GetPageByFilter(Page, PageSize, "Blood Type", cbBloodType.Text.Trim());
            else
                return await clsPatient.GetPageByFilter(Page, PageSize, cbFilter.Text.Trim(), tbFilter.Text);
        }

        private async Task LoadNextPage()
        {
            IsLoading = true;

            FirstRow = dgvPatients.FirstDisplayedScrollingRowIndex;

            NextPage = CurrentPage + 1;

            dtPage = IsFiltered ? await GetFilteredDataPage(NextPage) : await clsPatient.GetPage(NextPage, PageSize);

            if (dtPage.Rows.Count > 0)
            {
                dtPatients.Merge(dtPage);

                CurrentPage = NextPage;

                if (FirstRow >= 0)
                    dgvPatients.FirstDisplayedScrollingRowIndex = FirstRow;
            }
            else
                MessageBox.Show("Failed to load data", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

            IsLoading = false;
        }

        private async Task LoadFirstPage()
        {
            dtPatients.Clear();
            CurrentPage = 0;

            RowsCount = IsFiltered ? await GetFilteredRowsCount() : await clsPatient.GetCount();

            lblRowCount.Text = $"#{RowsCount}";

            if (RowsCount > 0)
                await LoadNextPage();
            else
                dtPatients.Clear();
        }

        private async void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFilter.Text)
            {
                case "None":
                    IsFiltered = false;
                    tbFilter.Visible = cbGender.Visible = cbBloodType.Visible = false;
                    tbFilter.Text = string.Empty;
                    await LoadFirstPage();
                    break;
                case "ID":
                    IsFiltered = true;
                    cbGender.Visible = cbBloodType.Visible = false;
                    tbFilter.Visible = true;

                    tbFilter.AllowLetters = tbFilter.AllowSpecialCharacters = false;
                    tbFilter.AllowDigits = true;
                    break;
                case "Medical Record No":
                    IsFiltered = true;
                    cbGender.Visible = cbBloodType.Visible = false;
                    tbFilter.Visible = true;

                    tbFilter.AllowSpecialCharacters = false;
                    tbFilter.AllowLetters = tbFilter.AllowDigits = true;
                    break;
                case "Full Name":
                    IsFiltered = true;
                    cbGender.Visible = cbBloodType.Visible = false;
                    tbFilter.Visible = true;

                    tbFilter.AllowSpecialCharacters = tbFilter.AllowDigits = false;
                    tbFilter.AllowLetters = true;
                    break;
                case "Gender":
                    tbFilter.Visible = cbBloodType.Visible = false;
                    tbFilter.Text = string.Empty;
                    cbGender.Visible = true;
                    cbGender.Text = "All";
                    break;
                case "Blood Type":
                    tbFilter.Visible = cbGender.Visible = false;
                    tbFilter.Text = string.Empty;
                    cbBloodType.Visible = true;
                    cbBloodType.Text = "All";
                    break;
            }

            if (tbFilter.Visible) tbFilter.Focus();
            else if (cbGender.Visible)
                cbGender.Focus();
            else if (cbBloodType.Visible)
                cbBloodType.Focus();
        }
        
        private async void dgvPatients_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                if (dtPatients.Rows.Count < RowsCount)
                {
                    if (dgvPatients.FirstDisplayedScrollingRowIndex + dgvPatients.DisplayedRowCount(false) >= dgvPatients.RowCount - 5)
                    {
                        if (!IsLoading)
                            await LoadNextPage();
                    }
                }
            }
        }

        private async void frmManagePatients_Load(object sender, EventArgs e)
        {
            dgvPatients.DataSource = dtPatients;

            await LoadFirstPage();

            if (dgvPatients.Columns?.Count > 0)
            {
                foreach (DataGridViewColumn column in dgvPatients.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }
    }
}
