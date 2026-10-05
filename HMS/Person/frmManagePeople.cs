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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS.People
{
    public partial class frmManagePeople : JOSubForm
    {
        DataTable dtPeople = new DataTable(), dtPage;

        bool IsLoading = false, IsFiltered = false;

        int CurrentPage = 0, NextPage = 1, PageSize = 15, FirstRow = 0, RowsCount = 0;

        public frmManagePeople()
        {
            InitializeComponent();
        }

        private string GetFilter()
        {
            switch (cbFilter.Text)
            {
                case "ID":
                    return "ID";
                case "First Name":
                    return "FirstName";
                case "Second Name":
                    return "SecondName";
                case "Last Name":
                    return "LastName";
                default:
                    return "";
            }
        }

        private async Task<int> GetFilteredRowsCount()
        {
            if (cbFilter.Text == "Gender")
                return await clsPerson.GetCountByFilter("Gender", cbGender.Text == "Male" ? "1" : "0");
            else
                return await clsPerson.GetCountByFilter(GetFilter(), tbFilter.Text);
        }

        private async Task<DataTable> GetFilteredDataPage(int Page)
        {
            if (cbFilter.Text == "Gender")
                return await clsPerson.GetPageByFilter(Page, PageSize, "Gender", cbGender.Text == "Male" ? "1" : "0");
            else
                return await clsPerson.GetPageByFilter(Page, PageSize, GetFilter(), tbFilter.Text);
        }

        private async Task LoadNextPage()
        {
            IsLoading = true;
            FirstRow = dgvPeople.FirstDisplayedScrollingRowIndex;

            NextPage = CurrentPage + 1;

            dtPage = IsFiltered ? await GetFilteredDataPage(NextPage) : await clsPerson.GetPage(NextPage, PageSize);

            if (dtPage.Rows.Count > 0)
            {
                dtPeople.Merge(dtPage);

                CurrentPage++;

                if (FirstRow >= 0)
                    dgvPeople.FirstDisplayedScrollingRowIndex = FirstRow;
            }
            else
                MessageBox.Show("Failed to load data", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

            IsLoading = false;
        }

        private async Task LoadFirstPage()
        {
            dtPeople.Clear();
            CurrentPage = 0;

            RowsCount = IsFiltered ? await GetFilteredRowsCount() : await clsPerson.GetCount();

            lblRowCount.Text = $"#{RowsCount}";

            if (RowsCount > 0)
                await LoadNextPage();
            else
                dtPeople.Clear();
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            await LoadFirstPage();
        }

        private async void showDetailstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails(Convert.ToInt32(dgvPeople.SelectedRows[0].Cells["ID"]?.Value?.ToString()));
            frm.ShowDialog();
        }

        private async void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewEditPerson frm = new frmAddNewEditPerson();
            frm.ShowDialog();
            RowsCount = IsFiltered ? await GetFilteredRowsCount() : await clsPerson.GetCount();

            lblRowCount.Text = $"#{RowsCount}";
        }

        private async void edittoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewEditPerson frm = new frmAddNewEditPerson(Convert.ToInt32(dgvPeople.SelectedRows[0].Cells["ID"]?.Value?.ToString()));
            frm.ShowDialog();
        }

        private async void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsFiltered = (cbGender.Text != "All");
            await LoadFirstPage();
        }

        private async void tbFilter_TextChanged(object sender, EventArgs e)
        {
            IsFiltered = (!string.IsNullOrEmpty(tbFilter.Text));
            await LoadFirstPage();
        }

        private async void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "None")
            {
                tbFilter.Text = string.Empty;

                tbFilter.Visible = cbGender.Visible = IsFiltered = false;


                await LoadFirstPage();
            }
            else if (cbFilter.Text == "Gender")
            {
                tbFilter.Visible = false;
                cbGender.Visible = IsFiltered = true;

                cbGender.Focus();
            }
            else
            {
                tbFilter.Visible = IsFiltered = true;
                cbGender.Visible = false;
                tbFilter.AllowLetters = cbFilter.Text == "ID" ? false : true;

                tbFilter.Focus();
            }
        }

        private async void dgvPeople_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                if (dtPeople.Rows.Count < RowsCount)
                {
                    if (dgvPeople.FirstDisplayedScrollingRowIndex + dgvPeople.DisplayedRowCount(false) >= dgvPeople.RowCount - 5)
                    {
                        if (!IsLoading)
                            await LoadNextPage();
                    }
                }
            }
        }

        private async void frmPeople_Load(object sender, EventArgs e)
        {
            dgvPeople.DataSource = dtPeople;

            await LoadFirstPage();

            if (dgvPeople.Columns?.Count > 0)
            {
                foreach (DataGridViewColumn column in dgvPeople.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }
    }
}
