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

namespace HMS.Medicine.Control
{
    public partial class ctrlMedicineSelector : UserControl
    {
        public event Action<DataRow, DataTable> OnRowSelected;

        bool IsFiltered = false, IsLoading = false, IsDosageFormsLoading = false, IsInitialized = false;
        int CurrentPage = 0, NextPage = 1, PageSize = 15, FirstRow = 0, RowsCount = 0;

        DataTable dtMedicines = new DataTable(), dtPage;

        public ctrlMedicineSelector()
        {
            InitializeComponent();
        }

        public async void Reload()
        {
            await LoadFirstPage();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void showDetailstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedicineDetails frm = new frmMedicineDetails(Convert.ToInt32(dgvMedicines.SelectedRows[0].Cells["ID"].Value));
            frm.ShowDialog();
        }

        private async void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmAddNewEditMedicine()).ShowDialog();
            RowsCount = IsFiltered ? await GetFilteredRowsCount() : await clsMedicine.GetCount();

            lblRowCount.Text = $"#{RowsCount}";
        }

        private void edittoolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmAddNewEditMedicine(Convert.ToInt32(dgvMedicines.SelectedRows[0].Cells["ID"].Value))).ShowDialog();
        }

        private async Task<int> GetFilteredRowsCount()
        {
            if (cbFilter.Text == "Dosage Form")
                return await clsMedicine.GetCountByFilter("Dosage Form", cbDosageForms.Text.Trim());
            else if (cbFilter.Text == "Active")
                return await clsMedicine.GetCountByFilter("Active", cbActive.Text.Trim());
            else
                return await clsMedicine.GetCountByFilter(cbFilter.Text.Trim(), tbFilter.Text);
        }

        private async Task<DataTable> GetFilteredDataPage(int Page)
        {
            if (cbFilter.Text == "Dosage Form")
                return await clsMedicine.GetPageByFilter(Page, PageSize, "Dosage Form", cbDosageForms.Text.Trim());
            else if (cbFilter.Text == "Active")
                return await clsMedicine.GetPageByFilter(Page, PageSize, "Active", cbActive.Text.Trim());
            else
                return await clsMedicine.GetPageByFilter(Page, PageSize, cbFilter.Text.Trim(), tbFilter.Text);
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            IsFiltered = (!string.IsNullOrEmpty(tbFilter.Text));
            await LoadFirstPage();
        }

        private void dgvMedicines_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            OnRowSelected?.Invoke(dtMedicines.Select().Where(row => row["ID"].Equals(dgvMedicines.SelectedRows[0].Cells["ID"].Value)).FirstOrDefault(), dtMedicines);
        }

        private async Task LoadNextPage()
        {
            IsLoading = true;

            FirstRow = dgvMedicines.FirstDisplayedScrollingRowIndex;

            NextPage = CurrentPage + 1;

            dtPage = IsFiltered ? await GetFilteredDataPage(NextPage) : await clsMedicine.GetPage(NextPage, PageSize);

            if (dtPage.Rows.Count > 0)
            {
                dtMedicines.Merge(dtPage);

                CurrentPage = NextPage;

                if (FirstRow >= 0)
                    dgvMedicines.FirstDisplayedScrollingRowIndex = FirstRow;
            }
            else
                MessageBox.Show("Failed to load data", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

            IsLoading = false;
        }

        private async Task LoadFirstPage()
        {
            dtMedicines.Clear();
            CurrentPage = 0;

            RowsCount = IsFiltered ? await GetFilteredRowsCount() : await clsMedicine.GetCount();

            lblRowCount.Text = $"#{RowsCount}";

            if (RowsCount > 0)
                await LoadNextPage();
            else
                dtMedicines.Clear();
        }

        private async void cbDosageForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsDosageFormsLoading)
            {
                IsFiltered = cbDosageForms.Text != "All";
                await LoadFirstPage();
            }
        }

        private async void cbActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsFiltered = cbActive.Text != "All";
            await LoadFirstPage();
        }

        private async void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFilter.Text)
            {
                case "None":
                    IsFiltered = false;
                    tbFilter.Visible = cbActive.Visible = cbDosageForms.Visible = btnSearch.Visible = false;
                    tbFilter.Text = string.Empty;
                    await LoadFirstPage();
                    break;
                case "ID":
                    IsFiltered = true;
                    cbActive.Visible = cbDosageForms.Visible = false;
                    tbFilter.Visible = btnSearch.Visible = true;

                    tbFilter.AllowLetters = tbFilter.AllowSpecialCharacters = false;
                    tbFilter.AllowDigits = true;
                    break;
                case "Name":
                    IsFiltered = true;
                    cbActive.Visible = cbDosageForms.Visible = false;
                    tbFilter.Visible = btnSearch.Visible = true;

                    tbFilter.AllowSpecialCharacters = false;
                    tbFilter.AllowLetters = tbFilter.AllowDigits = true;
                    break;
                case "Strength":
                    IsFiltered = true;
                    cbActive.Visible = cbDosageForms.Visible = false;
                    tbFilter.Visible = btnSearch.Visible = true;

                    tbFilter.AllowLetters = tbFilter.AllowSpecialCharacters = false;
                    tbFilter.AllowDigits = true;
                    break;
                case "Active":
                    tbFilter.Visible = cbDosageForms.Visible = btnSearch.Visible = false;
                    tbFilter.Text = string.Empty;
                    cbActive.Visible = true;
                    cbActive.Text = "All";
                    break;
                case "Dosage Form":
                    tbFilter.Visible = cbActive.Visible = btnSearch.Visible = false;
                    tbFilter.Text = string.Empty;
                    cbDosageForms.Visible = true;
                    cbDosageForms.Text = "All";
                    break;
            }

            if (tbFilter.Visible)
                tbFilter.Focus();
            else if (cbActive.Visible)
                cbActive.Focus();
            else if (cbDosageForms.Visible)
                cbDosageForms.Focus();
        }

        private void dgvMedicines_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvMedicines.Columns["Active"].Index && e.Value != null)
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

        private async void dgvMedicines_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                if (dtMedicines.Rows.Count < RowsCount)
                {
                    if (dgvMedicines.FirstDisplayedScrollingRowIndex + dgvMedicines.DisplayedRowCount(false) >= dgvMedicines.RowCount - 5)
                    {
                        if (!IsLoading)
                            await LoadNextPage();
                    }
                }
            }
        }

        private void LoadDosageForms()
        {
            IsDosageFormsLoading = true;
            List<string> lDosageForms = new List<string>();

            lDosageForms.Add("All");
            foreach (clsMedicine.enDosageForm DosageForm in Enum.GetValues(typeof(clsMedicine.enDosageForm)))
                lDosageForms.Add(DosageForm.ToString());

            cbDosageForms.DataSource = lDosageForms;
            IsDosageFormsLoading = false;
        }

        public async Task Initialize()
        {
            if (!IsInitialized)
            {
                LoadDosageForms();

                dgvMedicines.DataSource = dtMedicines;
                await LoadFirstPage();

                if (dgvMedicines.Columns?.Count > 0)
                {
                    foreach (DataGridViewColumn column in dgvMedicines.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
                IsInitialized = true;
            }
        }
    }
}
