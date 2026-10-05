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
using static HMS.BLL.clsPerson;

namespace HMS.Doctors
{
    public partial class frmManageDoctors : JOSubForm
    {
        bool IsFiltered = false, IsLoading = false;
        bool IsDepartmentsLoading = false, IsSpecializationsLoading = false;
        int CurrentPage = 0, NextPage = 1, PageSize = 15, FirstRow = 0, RowsCount = 0;

        DataTable dtDoctors = new DataTable(), dtPage;

        public frmManageDoctors()
        {
            InitializeComponent();
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            await LoadFirstPage();
        }

        private void dgvDoctors_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvDoctors.Columns["Active"].Index && e.Value != null)
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
                return await clsDoctor.GetCountByFilter("DepartmentName", cbDepartments.Text.Trim());
            else if (cbFilter.Text == "Specialization")
                return await clsDoctor.GetCountByFilter("SpecializationName", cbSpecializations.Text.Trim());
            else if (cbFilter.Text == "Active")
                return await clsDoctor.GetCountByFilter("Active", cbActive.Text.Trim());
            else
                return await clsDoctor.GetCountByFilter(cbFilter.Text.Trim(), tbFilter.Text);
        }

        private async Task<DataTable> GetFilteredDataPage(int Page)
        {
            if (cbFilter.Text == "Department")
                return await clsDoctor.GetPageByFilter(Page, PageSize, "DepartmentName", cbDepartments.Text.Trim());
            else if (cbFilter.Text == "Specialization")
                return await clsDoctor.GetPageByFilter(Page, PageSize, "SpecializationName", cbSpecializations.Text.Trim());
            else if (cbFilter.Text == "Active")
                return await clsDoctor.GetPageByFilter(Page, PageSize, "Active", cbActive.Text.Trim());
            else
                return await clsDoctor.GetPageByFilter(Page, PageSize, cbFilter.Text.Trim(), tbFilter.Text);
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
            new frmDoctorDetails(Convert.ToInt32(dgvDoctors.SelectedRows[0]?.Cells["ID"]?.Value)).ShowDialog();
        }

        private async void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddNewEditDoctor().ShowDialog();
            RowsCount = IsFiltered ? await GetFilteredRowsCount() : await clsDoctor.GetCount();

            lblRowCount.Text = $"#{RowsCount}";
        }

        private void edittoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddNewEditDoctor(Convert.ToInt32(dgvDoctors.SelectedRows[0]?.Cells["ID"]?.Value)).ShowDialog();
        }

        private void DeletetoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async Task LoadNextPage()
        {
            IsLoading = true;

            FirstRow = dgvDoctors.FirstDisplayedScrollingRowIndex;

            NextPage = CurrentPage + 1;

            dtPage = IsFiltered ? await GetFilteredDataPage(NextPage) : await clsDoctor.GetPage(NextPage, PageSize);

            if (dtPage.Rows.Count > 0)
            {
                dtDoctors.Merge(dtPage);

                CurrentPage++;

                if (FirstRow >= 0)
                    dgvDoctors.FirstDisplayedScrollingRowIndex = FirstRow;
            }
            else
                MessageBox.Show("Failed to load data", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

            IsLoading = false;
        }

        private async Task LoadFirstPage()
        {
            dtDoctors.Clear();
            CurrentPage = 0;

            RowsCount = IsFiltered ? await GetFilteredRowsCount() : await clsDoctor.GetCount();

            lblRowCount.Text = $"#{RowsCount}";

            if (RowsCount > 0)
                await LoadNextPage();
            else
                dtDoctors.Clear();
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

        private async void frmManageDoctors_Load(object sender, EventArgs e)
        {
            dgvDoctors.DataSource = dtDoctors;

            await LoadFirstPage();

            if (dgvDoctors.Columns?.Count > 0)
            {
                foreach (DataGridViewColumn column in dgvDoctors.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }

            await LoadDepartments();
            await LoadSpecializations();
        }

        private async void dgvDoctors_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                if (dtDoctors.Rows.Count < RowsCount)
                {
                    if (dgvDoctors.FirstDisplayedScrollingRowIndex + dgvDoctors.DisplayedRowCount(false) >= dgvDoctors.RowCount - 5)
                    {
                        if (!IsLoading)
                            await LoadNextPage();
                    }
                }
            }
        }
    }
}
