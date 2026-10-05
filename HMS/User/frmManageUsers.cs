using HMS.BLL;
using HMS.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Youssef.WinForms.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS
{
    public partial class frmManageUsers : JOSubForm
    {
        bool IsFiltered = false, IsLoading = false;
        DataTable dtUsers = new DataTable(), dtPage;
        int CurrentPage = 0, NextPage = 1, PageSize = 15, FirstRow = 0, RowsCount = 0;

        public frmManageUsers()
        {
            InitializeComponent();
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            await LoadFirstPage();
        }

        private async void dgvUsers_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                if (dtUsers.Rows.Count < RowsCount)
                {
                    if (dgvUsers.FirstDisplayedScrollingRowIndex + dgvUsers.DisplayedRowCount(false) >= dgvUsers.RowCount - 5)
                    {
                        if (!IsLoading)
                            await LoadNextPage();
                    }
                }
            }

        }
      
        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvUsers.Columns["Active"].Index && e.Value != null)
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

        private string GetFilter()
        {
            switch (cbFilter.Text)
            {
                case "ID":
                    return "ID";
                case "Username":
                    return "Username";
                default:
                    return "";
            }
        }

        private async Task<int> GetFilteredRowsCount()
        {
            if (cbFilter.Text == "Active")
                return await clsUser.GetCountByFilter("IsActive", cbActive.Text == "Active" ? "1" : "0");
            else if (cbFilter.Text == "User Role")
                return await clsUser.GetCountByFilter("UserRoleID", cbUserRoles.SelectedValue.ToString());
            else
                return await clsUser.GetCountByFilter(GetFilter(), tbFilter.Text);
        }

        private async Task<DataTable> GetFilteredDataPage(int Page)
        {
            if (cbFilter.Text == "Active")
                return await clsUser.GetPageByFilter(Page, PageSize, "IsActive", cbActive.Text == "Active" ? "1" : "0");
            else if (cbFilter.Text == "User Role")
                return await clsUser.GetPageByFilter(Page, PageSize, "UserRoleID", cbUserRoles.SelectedValue.ToString());
            else
                return await clsUser.GetPageByFilter(Page, PageSize, GetFilter(), tbFilter.Text);
        }

        private async Task LoadNextPage()
        {
            IsLoading = true;
            FirstRow = dgvUsers.FirstDisplayedScrollingRowIndex;

            NextPage = CurrentPage + 1;

            dtPage = IsFiltered ? await GetFilteredDataPage(NextPage) : await clsUser.GetPage(NextPage, PageSize);

            if (dtPage.Rows.Count > 0)
            {
                dtUsers.Merge(dtPage);

                CurrentPage++;

                if (FirstRow >= 0)
                    dgvUsers.FirstDisplayedScrollingRowIndex = FirstRow;
            }
            else
                MessageBox.Show("Failed to load data", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

            IsLoading = false;
        }

        private async Task LoadFirstPage()
        {
            dtUsers.Clear();
            CurrentPage = 0;

            RowsCount = IsFiltered ? await GetFilteredRowsCount() : await clsUser.GetCount();

            lblRowCount.Text = $"#{RowsCount}";

            if (RowsCount > 0)
                await LoadNextPage();
            else
                dtUsers.Clear();
        }

        private async Task LoadUserRoles()
        {
            DataTable dtRoles = await clsUserRole.GetAll(false);
            DataRow row = dtRoles.NewRow();
            row["ID"] = 0;
            row["Name"] = "All";
            dtRoles.Rows.InsertAt(row, 0);

            cbUserRoles.DataSource = dtRoles;
            cbUserRoles.DisplayMember = "Name";
            cbUserRoles.ValueMember = "ID";
        }

        private async void frmManageUsers_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = dtUsers;

            await LoadFirstPage();

            await LoadUserRoles();

            if (dgvUsers.Columns?.Count > 0)
            {
                foreach (DataGridViewColumn column in dgvUsers.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private async void cbUserRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsFiltered = (cbUserRoles.Text != "All");
            await LoadFirstPage();
        }

        private async void cbActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsFiltered = (cbActive.Text != "All");
            await LoadFirstPage();
        }

        private void ChangePasswordtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmChangeUserPassword(Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["ID"].Value)).ShowDialog();
        }

        private void showDetailstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmUserDetails(Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["ID"].Value)).ShowDialog();
        }

        private async void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddNewEditUser().ShowDialog();
            RowsCount = IsFiltered ? await GetFilteredRowsCount() : await clsUser.GetCount();

            lblRowCount.Text = $"#{RowsCount}";
        }

        private void edittoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddNewEditUser(Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["ID"].Value)).ShowDialog();
        }

        private void DeletetoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFilter.Text)
            {
                case "None":
                    tbFilter.Visible = cbActive.Visible = IsFiltered = false;
                    await LoadFirstPage();
                    break;
                case "ID":
                    tbFilter.Visible = true;
                    tbFilter.AllowDigits = true;
                    cbUserRoles.Visible = cbActive.Visible = tbFilter.AllowLetters = tbFilter.AllowSpecialCharacters = false;
                    tbFilter.Focus();
                    break;
                case "Username":
                    tbFilter.Visible = true;
                    tbFilter.AllowLetters = tbFilter.AllowSpecialCharacters = true;
                    cbUserRoles.Visible = cbActive.Visible = tbFilter.AllowDigits = false;
                    tbFilter.Focus();
                    break;
                case "Active":
                    cbUserRoles.Visible = tbFilter.Visible = false;
                    cbActive.Visible = true;
                    cbActive.Focus();
                    break;
                case "User Role":
                    cbActive.Visible = tbFilter.Visible = false;
                    cbUserRoles.Visible = true;
                    cbUserRoles.Focus();
                    break;
            }
        }

        private async void tbFilter_TextChanged(object sender, EventArgs e)
        {
            IsFiltered = !string.IsNullOrEmpty(tbFilter.Text);
            await LoadFirstPage();
        }
    }
}