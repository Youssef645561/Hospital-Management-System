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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS.Lab_Test
{
    public partial class frmManageLabTests : JOSubForm
    {
        bool IsFiltered = false, IsLoading = false, IsTestTypesLoading = false;
        int CurrentPage = 0, NextPage = 1, PageSize = 15, FirstRow = 0, RowsCount = 0;

        DataTable dtLabTests = new DataTable(), dtPage;

        public frmManageLabTests()
        {
            InitializeComponent();
        }

        private async void tbFilter_TextChanged(object sender, EventArgs e)
        {
            IsFiltered = (!string.IsNullOrEmpty(tbFilter.Text));
            await LoadFirstPage();
        }

        private async void cbTestTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsTestTypesLoading)
            {
                IsFiltered = (cbTestTypes.Text != "All");
                await LoadFirstPage();
            }
        }

        private async void cbStatuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsFiltered = (cbStatuses.Text != "All");
            await LoadFirstPage();
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            await LoadFirstPage();
        }

        private async void LabTesthistorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmLabTestAppointmentsHistory frm = new frmLabTestAppointmentsHistory(Convert.ToInt32(dgvLabTests.SelectedRows[0].Cells["ID"].Value));
            //frm.ShowDialog();
        }

        private async Task<int> GetFilteredRowsCount()
        {
            if (cbFilter.Text == "ID")
                return await clsLabTest.GetCountByFilter("ID", tbFilter.Text.Trim());
            else if (cbFilter.Text == "Medical Record No")
                return await clsLabTest.GetCountByFilter("PatientMedicalRecordNo", tbFilter.Text.Trim());
            else if (cbFilter.Text == "Status")
                return await clsLabTest.GetCountByFilter("Status", cbStatuses.Text.Trim());
            else if (cbFilter.Text == "Test Type")
                return await clsLabTest.GetCountByFilter("TestTypeName", cbTestTypes.Text.Trim());
            else
                return await clsLabTest.GetCountByFilter(cbFilter.Text.Trim(), tbFilter.Text);
        }

        private void dgvLabTests_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvLabTests.Columns[e.ColumnIndex].Name == "Status")
            {
                switch (e.Value?.ToString())
                {
                    case "Pending":
                        e.CellStyle.ForeColor = Color.DarkOrange;
                        break;

                    case "In Progress":
                        e.CellStyle.ForeColor = Color.RoyalBlue;
                        break;

                    case "Completed":
                        e.CellStyle.ForeColor = Color.ForestGreen;
                        break;

                    case "Cancelled":
                        e.CellStyle.ForeColor = Color.Firebrick;
                        break;
                }
            }

            else if (dgvLabTests.Columns[e.ColumnIndex].Name == "Result")
            {
                switch (e.Value?.ToString())
                {
                    case "No Result Yet":
                        e.CellStyle.ForeColor = Color.DarkOrange;
                        break;

                    case "Positive":
                        e.CellStyle.ForeColor = Color.Green;
                        break;

                    case "Negative":
                        e.CellStyle.ForeColor = Color.Red;
                        break;
                }
            }
        }

        private void ViewResulttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvLabTests.SelectedRows.Count > 0)
            {
                frmLabTestDetails frm = new frmLabTestDetails(Convert.ToInt32(dgvLabTests.SelectedRows[0].Cells["ID"].Value));
                frm.ShowDialog();
            }
        }

        private async void StartTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLabTests.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to start the selected lab test?", "Confirm Start", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (await clsLabTest.StartLabTest(Convert.ToInt32(dgvLabTests.SelectedRows[0].Cells["ID"].Value)))
                    {
                        MessageBox.Show("Lab test started successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to start the lab test.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CompleteTesttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCompleteLabTest(Convert.ToInt32(dgvLabTests.SelectedRows[0].Cells["ID"].Value)).ShowDialog();
        }

        private async void CanceltoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLabTests.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to cancel the selected lab test?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    (bool IsCancelled, decimal RefundAmount) = await clsLabTest.CancelLabTest(Convert.ToInt32(dgvLabTests.SelectedRows[0].Cells["ID"].Value));

                    if (IsCancelled)
                    {
                        MessageBox.Show($"Lab test canceled successfully.\nRefund amount: {RefundAmount:C}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to cancel the lab test.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cmsLabTests_Opening(object sender, CancelEventArgs e)
        {
            if (dgvLabTests.CurrentRow == null)
            {
                e.Cancel = true;
                return;
            }

            string status = dgvLabTests.CurrentRow.Cells["Status"].Value?.ToString();

            StartTestToolStripMenuItem.Enabled = false;
            CompleteTesttoolStripMenuItem.Enabled = false;
            CanceltoolStripMenuItem.Enabled = false;

            switch (status)
            {
                case "Pending":
                    StartTestToolStripMenuItem.Enabled = true;
                    CanceltoolStripMenuItem.Enabled = true;
                    break;

                case "In Progress":
                    CompleteTesttoolStripMenuItem.Enabled = true;
                    CanceltoolStripMenuItem.Enabled = true;
                    break;

                case "Completed":
                case "Cancelled":
                    break;
            }
        }
        
        private async Task<DataTable> GetFilteredDataPage(int Page)
        {
            if (cbFilter.Text == "ID")
                return await clsLabTest.GetPageByFilter(Page, PageSize, "ID", tbFilter.Text.Trim());
            else if (cbFilter.Text == "Medical Record No")
                return await clsLabTest.GetPageByFilter(Page, PageSize, "PatientMedicalRecordNo", tbFilter.Text.Trim());
            else if (cbFilter.Text == "Status")
                return await clsLabTest.GetPageByFilter(Page, PageSize, "Status", cbStatuses.Text.Trim());
            else if (cbFilter.Text == "Test Type")
                return await clsLabTest.GetPageByFilter(Page, PageSize, "TestTypeName", cbTestTypes.Text.Trim());
            else
                return await clsLabTest.GetPageByFilter(Page, PageSize, cbFilter.Text.Trim(), tbFilter.Text);
        }

        private async Task LoadNextPage()
        {
            IsLoading = true;

            FirstRow = dgvLabTests.FirstDisplayedScrollingRowIndex;

            NextPage = CurrentPage + 1;

            dtPage = IsFiltered ? await GetFilteredDataPage(NextPage) : await clsLabTest.GetPage(NextPage, PageSize);

            if (dtPage.Rows.Count > 0)
            {
                dtLabTests.Merge(dtPage);

                CurrentPage = NextPage;

                if (FirstRow >= 0)
                    dgvLabTests.FirstDisplayedScrollingRowIndex = FirstRow;
            }
            else
                MessageBox.Show("Failed to load data", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

            IsLoading = false;
        }

        private async Task LoadFirstPage()
        {
            dtLabTests.Clear();
            CurrentPage = 0;

            RowsCount = IsFiltered ? await GetFilteredRowsCount() : await clsLabTest.GetCount();

            lblRowCount.Text = $"#{RowsCount}";

            if (RowsCount > 0)
                await LoadNextPage();
            else
                dtLabTests.Clear();
        }

        private async void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFilter.Text)
            {
                case "None":
                    IsFiltered = false;
                    tbFilter.Visible = cbStatuses.Visible = cbTestTypes.Visible = false;
                    tbFilter.Text = string.Empty;
                    await LoadFirstPage();
                    break;
                case "ID":
                    IsFiltered = true;
                    cbStatuses.Visible = cbTestTypes.Visible = false;
                    tbFilter.Visible = true;

                    tbFilter.AllowLetters = tbFilter.AllowSpecialCharacters = false;
                    tbFilter.AllowDigits = true;
                    break;
                case "Medical Record No":
                    IsFiltered = true;
                    cbStatuses.Visible = cbTestTypes.Visible = false;
                    tbFilter.Visible = true;

                    tbFilter.AllowSpecialCharacters = false;
                    tbFilter.AllowLetters = tbFilter.AllowDigits = true;
                    break;
                case "Status":
                    tbFilter.Visible = cbTestTypes.Visible = false;
                    tbFilter.Text = string.Empty;
                    cbStatuses.Visible = true;
                    cbStatuses.Text = "All";
                    break;
                case "Test Type":
                    tbFilter.Visible = cbStatuses.Visible = false;
                    tbFilter.Text = string.Empty;
                    cbTestTypes.Visible = true;
                    cbTestTypes.Text = "All";
                    break;
            }

            if (tbFilter.Visible) tbFilter.Focus();
            else if (cbStatuses.Visible)
                cbStatuses.Focus();
            else if (cbTestTypes.Visible)
                cbTestTypes.Focus();
        }

        private async void dgvLabTests_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                if (dtLabTests.Rows.Count < RowsCount)
                {
                    if (dgvLabTests.FirstDisplayedScrollingRowIndex + dgvLabTests.DisplayedRowCount(false) >= dgvLabTests.RowCount - 5)
                    {
                        if (!IsLoading)
                            await LoadNextPage();
                    }
                }
            }
        }

        private async void frmManageLabTests_Load(object sender, EventArgs e)
        {
            dgvLabTests.DataSource = dtLabTests;

            await LoadFirstPage();
            await LoadTestTypes();

            if (dgvLabTests.Columns?.Count > 0)
            {
                foreach (DataGridViewColumn column in dgvLabTests.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private async Task LoadTestTypes()
        {
            IsTestTypesLoading = true;
            DataTable dtTestTypes = await clsTestType.GetAll();

            DataRow row = dtTestTypes.NewRow();
            row["ID"] = 0;
            row["Name"] = "All";
            row["Fees"] = 0;
            row["IsAvailable"] = false;
            dtTestTypes.Rows.InsertAt(row, 0);

            cbTestTypes.DataSource = dtTestTypes;
            cbTestTypes.DisplayMember = "Name";
            cbTestTypes.ValueMember = "ID";

            IsTestTypesLoading = false;
        }
    }
}
