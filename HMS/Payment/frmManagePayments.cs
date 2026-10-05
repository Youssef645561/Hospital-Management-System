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
using static HMS.BLL.clsPerson;

namespace HMS.Payment
{
    public partial class frmManagePayments : JOSubForm
    {

        bool IsFiltered = false, IsLoading = false, IsStatusesLoading = false, IsMethodsLoading = false;
        int CurrentPage = 0, NextPage = 1, PageSize = 15, FirstRow = 0, RowsCount = 0;

        DataTable dtPayments = new DataTable(), dtPage;

        string StatusCellValue;

        public frmManagePayments()
        {
            InitializeComponent();
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            await LoadFirstPage();
        }

        private void showDetailstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaymentDetails frm = new frmPaymentDetails(Convert.ToInt32(dgvPayments.SelectedRows[0].Cells["ID"].Value));
            frm.ShowDialog();
        }

        private async void PerformPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmAddNewEditPayment()).ShowDialog();
            RowsCount = IsFiltered ? await GetFilteredRowsCount() : await clsPayment.GetCount();

            lblRowCount.Text = $"#{RowsCount}";
        }

        private async void RefundtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to refund this payment?", "Confirm Refund", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                (bool IsRefunded, decimal RefundAmount) = await clsPayment.RefundPayment(dgvPayments.SelectedRows[0].Cells["ID"].Value as int?);
                if (IsRefunded)
                    MessageBox.Show($"Payment refunded successfully.\nRefund Amount: {RefundAmount}", "Refund Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed to refund the payment.", "Refund Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void patientchargedetailstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatientChargeDetails frm = new frmPatientChargeDetails(Convert.ToInt32(dgvPayments.SelectedRows[0].Cells["PatientChargeID"].Value));
            frm.ShowDialog();
        }

        private void dgvPayments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvPayments.Columns[e.ColumnIndex].Name == "Status")
            {
                switch (e.Value?.ToString())
                {
                    case "Completed":
                        e.CellStyle.ForeColor = Color.ForestGreen;
                        break;

                    case "Refunded":
                        e.CellStyle.ForeColor = Color.DarkOrange;
                        break;
                }
            }
        }

        private void cmsPayments_Opening(object sender, CancelEventArgs e)
        {
            if (dgvPayments.CurrentRow == null)
            {
                e.Cancel = true;
                return;
            }

            StatusCellValue = dgvPayments.CurrentRow.Cells["Status"].Value?.ToString();

            RefundtoolStripMenuItem.Enabled = false;

            switch (StatusCellValue)
            {
                case "Completed":
                    RefundtoolStripMenuItem.Enabled = true;
                    break;

                case "Refunded":
                    break;
            }
        }

        private async Task<DataTable> GetFilteredDataPage(int Page)
        {
            if (cbFilter.Text == "Method")
                return await clsPayment.GetPageByFilter(Page, PageSize, "Method", ((byte)(clsPayment.enStatus)cbMethods.SelectedItem).ToString());
            else if (cbFilter.Text == "Status")
                return await clsPayment.GetPageByFilter(Page, PageSize, "Status", ((byte)(clsPayment.enStatus)cbStatuses.SelectedItem).ToString());
            else
                return await clsPayment.GetPageByFilter(Page, PageSize, cbFilter.Text.Trim(), tbFilter.Text);
        }

        private async Task<int> GetFilteredRowsCount()
        {
            if (cbFilter.Text == "Method")
                return await clsPayment.GetCountByFilter("Method", ((byte)(clsPayment.enStatus)cbMethods.SelectedItem).ToString());
            else if (cbFilter.Text == "Status")
                return await clsPayment.GetCountByFilter("Status", ((byte)(clsPayment.enStatus)cbStatuses.SelectedItem).ToString());
            else
                return await clsPayment.GetCountByFilter(cbFilter.Text.Trim(), tbFilter.Text);
        }

        private async Task LoadNextPage()
        {
            IsLoading = true;

            FirstRow = dgvPayments.FirstDisplayedScrollingRowIndex;

            NextPage = CurrentPage + 1;

            dtPage = IsFiltered ? await GetFilteredDataPage(NextPage) : await clsPayment.GetPage(NextPage, PageSize);

            if (dtPage.Rows.Count > 0)
            {
                dtPayments.Merge(dtPage);

                CurrentPage = NextPage;

                if (FirstRow >= 0)
                    dgvPayments.FirstDisplayedScrollingRowIndex = FirstRow;
            }
            else
                MessageBox.Show("Failed to load data", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

            IsLoading = false;
        }

        private async Task LoadFirstPage()
        {
            dtPayments.Clear();
            CurrentPage = 0;

            RowsCount = IsFiltered ? await GetFilteredRowsCount() : await clsPayment.GetCount();

            lblRowCount.Text = $"#{RowsCount}";

            if (RowsCount > 0)
                await LoadNextPage();
            else
                dtPayments.Clear();
        }

        private async void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFilter.Text)
            {
                case "None":
                    IsFiltered = false;
                    tbFilter.Visible = cbMethods.Visible = cbStatuses.Visible = false;
                    tbFilter.Text = string.Empty;
                    await LoadFirstPage();
                    break;
                case "ID":
                    IsFiltered = true;
                    cbMethods.Visible = cbStatuses.Visible = false;
                    tbFilter.Visible = true;

                    tbFilter.AllowLetters = tbFilter.AllowSpecialCharacters = false;
                    tbFilter.AllowDigits = true;
                    break;
                case "Method":
                    tbFilter.Visible = cbStatuses.Visible = false;
                    tbFilter.Text = string.Empty;
                    cbMethods.Visible = true;
                    break;
                case "Status":
                    tbFilter.Visible = cbMethods.Visible = false;
                    tbFilter.Text = string.Empty;
                    cbStatuses.Visible = true;
                    break;
            }

            if (tbFilter.Visible) tbFilter.Focus();
            else if (cbMethods.Visible)
                cbMethods.Focus();
            else if (cbStatuses.Visible)
                cbStatuses.Focus();
        }
       
        private async void tbFilter_TextChanged(object sender, EventArgs e)
        {
            IsFiltered = (!string.IsNullOrEmpty(tbFilter.Text));
            await LoadFirstPage();
        }

        private async void cbMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsMethodsLoading)
            {
                IsFiltered = (cbMethods.Text != "All");
                await LoadFirstPage();
            }
        }

        private async void cbStatuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsStatusesLoading)
            {
                IsFiltered = (cbStatuses.Text != "All");
                await LoadFirstPage();
            }
        }

        private async void dgvPayments_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                if (dtPayments.Rows.Count < RowsCount)
                {
                    if (dgvPayments.FirstDisplayedScrollingRowIndex + dgvPayments.DisplayedRowCount(false) >= dgvPayments.RowCount - 5)
                    {
                        if (!IsLoading)
                            await LoadNextPage();
                    }
                }
            }
        }

        private async void frmManagePayments_Load(object sender, EventArgs e)
        {
            dgvPayments.DataSource = dtPayments;

            LoadStatuses();
            LoadMethods();

            await LoadFirstPage();

            if (dgvPayments.Columns?.Count > 0)
            {
                foreach (DataGridViewColumn column in dgvPayments.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                dgvPayments.Columns["PatientChargeID"].Visible = false;
            }
        }

        private void LoadStatuses()
        {
            IsStatusesLoading = true;
            cbStatuses.DataSource = Enum.GetValues(typeof(clsPayment.enStatus));
            IsStatusesLoading = false;
        }

        private void LoadMethods()
        {
            IsMethodsLoading = true;
            cbMethods.DataSource = Enum.GetValues(typeof(clsPayment.enMethod));
            IsMethodsLoading = false;
        }
    }
}
