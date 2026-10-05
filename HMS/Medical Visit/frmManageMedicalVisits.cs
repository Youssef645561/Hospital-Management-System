using HMS.Appointment;
using HMS.BLL;
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

namespace HMS.Medical_Visit
{
    public partial class frmManageMedicalVisits : JOSubForm
    {
        bool IsFiltered = false, IsLoading = false;
        bool IsDepartmentsLoading = false, IsSpecializationsLoading = false;
        int CurrentPage = 0, NextPage = 1, PageSize = 15, FirstRow = 0, RowsCount = 0;

        DataTable dtMedicalVisits = new DataTable(), dtPage;

        public frmManageMedicalVisits()
        {
            InitializeComponent();
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            await LoadFirstPage();
        }

        private void dgvMedicalVisits_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvMedicalVisits.Columns["Active"].Index && e.Value != null)
            {
                if (e.Value.ToString() == "Active")
                {
                    //e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if (e.Value.ToString() == "Inactive")
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
                    tbFilter.Visible = cbDepartments.Visible = cbSpecializations.Visible = cbActive.Visible = false;
                    tbFilter.Text = string.Empty;
                    await LoadFirstPage();
                    break;
                case "ID":
                    IsFiltered = true;
                    cbDepartments.Visible = cbSpecializations.Visible = cbActive.Visible = false;
                    tbFilter.Visible = true;

                    tbFilter.AllowLetters = tbFilter.AllowSpecialCharacters = false;
                    tbFilter.AllowDigits = true;
                    break;
                case "Full Name":
                    IsFiltered = true;
                    cbDepartments.Visible = cbSpecializations.Visible = cbActive.Visible = false;
                    tbFilter.Visible = true;

                    tbFilter.AllowSpecialCharacters = tbFilter.AllowDigits = false;
                    tbFilter.AllowLetters = true;
                    break;
                case "Department":
                    tbFilter.Visible = cbSpecializations.Visible = cbActive.Visible = false;
                    tbFilter.Text = string.Empty;
                    cbDepartments.Visible = true;
                    cbDepartments.Text = "All";
                    break;
                case "Specialization":
                    tbFilter.Visible = cbDepartments.Visible = cbActive.Visible = false;
                    tbFilter.Text = string.Empty;
                    cbSpecializations.Visible = true;
                    cbSpecializations.Text = "All";
                    break;
                case "Active":
                    tbFilter.Visible = cbDepartments.Visible = cbSpecializations.Visible = false;
                    tbFilter.Text = string.Empty;
                    cbActive.Visible = true;
                    cbActive.Text = "All";
                    break;
            }

            if (tbFilter.Visible) tbFilter.Focus();
            else if (cbDepartments.Visible)
                cbDepartments.Focus();
            else if (cbSpecializations.Visible)
                cbSpecializations.Focus();
            else if (cbActive.Visible)
                cbActive.Focus();
        }

        private async Task<int> GetFilteredRowsCount()
        {
            if (cbFilter.Text == "Department")
                return await clsMedicalVisit.GetCountByFilter("Department", cbDepartments.Text.Trim());
            else if (cbFilter.Text == "Specialization")
                return await clsMedicalVisit.GetCountByFilter("Specialization", cbSpecializations.Text.Trim());
            else if (cbFilter.Text == "Active")
                return await clsMedicalVisit.GetCountByFilter("Active", cbActive.Text.Trim());
            else
                return await clsMedicalVisit.GetCountByFilter(cbFilter.Text.Trim(), tbFilter.Text);
        }

        private async Task<DataTable> GetFilteredDataPage(int Page)
        {
            if (cbFilter.Text == "Department")
                return await clsMedicalVisit.GetPageByFilter(Page, PageSize, "Department", cbDepartments.Text.Trim());
            else if (cbFilter.Text == "Specialization")
                return await clsMedicalVisit.GetPageByFilter(Page, PageSize, "Specialization", cbSpecializations.Text.Trim());
            else if (cbFilter.Text == "Active")
                return await clsMedicalVisit.GetPageByFilter(Page, PageSize, "Active", cbActive.Text.Trim());
            else
                return await clsMedicalVisit.GetPageByFilter(Page, PageSize, cbFilter.Text.Trim(), tbFilter.Text);
        }

        private async void cbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsDepartmentsLoading)
            {
                IsFiltered = (cbDepartments.Text != "All");
                await LoadFirstPage();
            }
        }

        private async void cbSpecializations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsSpecializationsLoading)
            {
                IsFiltered = (cbSpecializations.Text != "All");
                await LoadFirstPage();
            }
        }

        private async void cbActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsFiltered = (cbActive.Text != "All");
            await LoadFirstPage();
        }

        private void showDetailstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmMedicalVisitDetails(Convert.ToInt32(dgvMedicalVisits.SelectedRows[0]?.Cells["ID"]?.Value)).ShowDialog();
        }

        private async void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddNewEditMedicalVisit().ShowDialog();
            RowsCount = IsFiltered ? await GetFilteredRowsCount() : await clsMedicalVisit.GetCount();

            lblRowCount.Text = $"#{RowsCount}";
        }

        private void edittoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewEditMedicalVisit frm = new frmAddNewEditMedicalVisit();
            frm.EditMedicalVisit(Convert.ToInt32(dgvMedicalVisits.SelectedRows[0].Cells["ID"].Value));
            frm.ShowDialog();
        }

        private void DeletetoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void patienthistorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatientAppointmentsHistory frm = new frmPatientAppointmentsHistory(Convert.ToInt32(dgvMedicalVisits.SelectedRows[0].Cells["PatientID"].Value));
            frm.ShowDialog();
        }
        
        private async Task LoadNextPage()
        {
            IsLoading = true;

            FirstRow = dgvMedicalVisits.FirstDisplayedScrollingRowIndex;

            NextPage = CurrentPage + 1;

            dtPage = IsFiltered ? await GetFilteredDataPage(NextPage) : await clsMedicalVisit.GetPage(NextPage, PageSize);

            if (dtPage.Rows.Count > 0)
            {
                dtMedicalVisits.Merge(dtPage);

                CurrentPage++;

                if (FirstRow >= 0)
                    dgvMedicalVisits.FirstDisplayedScrollingRowIndex = FirstRow;
            }
            else
                MessageBox.Show("Failed to load data", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

            IsLoading = false;
        }

        private async Task LoadFirstPage()
        {
            dtMedicalVisits.Clear();
            CurrentPage = 0;

            RowsCount = IsFiltered ? await GetFilteredRowsCount() : await clsMedicalVisit.GetCount();

            lblRowCount.Text = $"#{RowsCount}";

            if (RowsCount > 0)
                await LoadNextPage();
            else
                dtMedicalVisits.Clear();
        }

        private async Task LoadDepartments()
        {
            IsDepartmentsLoading = true;

            DataTable dtDepartments = await clsDepartment.GetAll();
            DataRow row = dtDepartments.NewRow();
            row["ID"] = 0;
            row["Name"] = "All";
            dtDepartments.Rows.InsertAt(row, 0);

            cbDepartments.DataSource = dtDepartments;
            cbDepartments.DisplayMember = "Name";
            cbDepartments.ValueMember = "ID";

            IsDepartmentsLoading = false;
        }

        private async Task LoadSpecializations()
        {
            IsSpecializationsLoading = true;

            DataTable dtSpecializations = await clsSpecialization.GetAll();
            DataRow row = dtSpecializations.NewRow();
            row["ID"] = 0;
            row["Name"] = "All";
            dtSpecializations.Rows.InsertAt(row, 0);

            cbSpecializations.DataSource = dtSpecializations;
            cbSpecializations.DisplayMember = "Name";
            cbSpecializations.ValueMember = "ID";
            IsSpecializationsLoading = false;
        }

        private async void frmManageMedicalVisits_Load(object sender, EventArgs e)
        {
            dgvMedicalVisits.DataSource = dtMedicalVisits;

            await LoadFirstPage();

            if (dgvMedicalVisits.Columns?.Count > 0)
            {
                foreach (DataGridViewColumn column in dgvMedicalVisits.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                dgvMedicalVisits.Columns["PatientID"].Visible = false;
            }

            await LoadDepartments();
            await LoadSpecializations();
        }

        private async void dgvMedicalVisits_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
