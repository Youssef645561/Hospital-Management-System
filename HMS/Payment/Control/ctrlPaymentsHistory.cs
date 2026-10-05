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

namespace HMS.Payment.Control
{
    public partial class ctrlPaymentsHistory : UserControl
    {
        public ctrlPaymentsHistory()
        {
            InitializeComponent();
        }

        private int? _PatientChargeID;
        public int? PatientChargeID { get { return _PatientChargeID; } }

        private DataTable _dtPayments = null;
        public DataTable dtPayments { get { return _dtPayments; } }

        string StatusCellValue;

        private async Task LoadPaymentsData()
        {
            dgvPayments.DataSource = _dtPayments = await clsPayment.GetAll(PatientChargeID);
            lblRowCount.Text = $"#{_dtPayments.Rows.Count}";
        }

        public async Task LoadPayments(int PatientChargeID, clsPatientCharge.enStatus Status)
        {
            if (PatientChargeID > 0)
            {
                this._PatientChargeID = PatientChargeID;

                PerformPaymentToolStripMenuItem.Enabled = Status == clsPatientCharge.enStatus.Unpaid || Status == clsPatientCharge.enStatus.PartiallyPaid;

                gbPayments.Values.Description = $"Patient Charge ID = {PatientChargeID}";

                await LoadPaymentsData();

                if (dgvPayments.Columns?.Count > 0)
                {
                    foreach (DataGridViewColumn column in dgvPayments.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    dgvPayments.Columns["PatientChargeID"].Visible = false;
                }
            }
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

        private async void reloadtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            await LoadPaymentsData();
        }

        private void showDetailstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaymentDetails frm = new frmPaymentDetails(Convert.ToInt32(dgvPayments.SelectedRows[0].Cells["ID"].Value));
            frm.ShowDialog();
        }

        private async void PerformPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewEditPayment frm = new frmAddNewEditPayment();
            await frm.LoadPatientCharge(_PatientChargeID.Value);
            frm.ShowDialog();
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
    }
}
