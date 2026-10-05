using Common;
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
    public partial class ctrlPaymentDetails : UserControl
    {
        public ctrlPaymentDetails()
        {
            InitializeComponent();
        }

        private clsPayment _PaymentData;
        public clsPayment PaymentData { get { return _PaymentData; } }

        private async void LoadEmptyScreen()
        {
            lblPatientChargeDetails.Enabled = false;
            lblID.Text = "???";
            lblTransactionNo.Text = "???";
            lblStatus.Text = "???";
            lblMethod.Text = "???";
            lblPaidAmount.Text = "???";
            lblCreatedDate.Text = "???";
            lblCreatedBy.Text = "???";

            lblStatus.StateCommon.ShortText.Color1 = Color.Black;
        }

        private async void LoadDataScreen()
        {
            lblPatientChargeDetails.Enabled = true;
            lblID.Text = _PaymentData.ID.ToString() ?? "???";
            lblTransactionNo.Text = _PaymentData.TransactionNo?.ToString() ?? "???";
            lblStatus.Text = _PaymentData.Status?.ToString() ?? "???";
            lblMethod.Text = _PaymentData.Method?.ToString() ?? "???";
            lblPaidAmount.Text = _PaymentData.PaidAmount?.ToString() ?? "???";
            lblCreatedDate.Text = clsUtility.DateTimeFormat(_PaymentData.CreatedDate) ?? "???";
            lblCreatedBy.Text = _PaymentData.CreatedByUsername ?? "???";

            switch (_PaymentData.Status)
            {
                case clsPayment.enStatus.Completed:
                    lblStatus.StateCommon.ShortText.Color1 = Color.ForestGreen;
                    break;

                case clsPayment.enStatus.Refund:
                    lblStatus.StateCommon.ShortText.Color1 = Color.DarkOrange;
                    break;
            }
        }

        public async Task LoadPaymentData(int Paymentid)
        {
            if (Paymentid > 0)
            {
                _PaymentData = await clsPayment.Find(Paymentid);

                if (_PaymentData != null)
                    LoadDataScreen();
                else
                    LoadEmptyScreen();
            }
            else
            {
                _PaymentData = null;
                LoadEmptyScreen();
            }
        }

        public void LoadPaymentData(clsPayment Payment)
        {
            if (Payment != null)
            {
                _PaymentData = Payment;
                LoadDataScreen();
            }
            else
            {
                _PaymentData = null;
                LoadEmptyScreen();
            }
        }

        private void lblPatientChargeDetails_LinkClicked(object sender, EventArgs e)
        {
            frmPatientChargeDetails frm = new frmPatientChargeDetails(_PaymentData.PatientChargeID.Value);
            frm.ShowDialog();
        }
    }
}
