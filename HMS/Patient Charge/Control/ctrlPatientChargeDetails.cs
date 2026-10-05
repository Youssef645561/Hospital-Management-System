using Common;
using HMS.BLL;
using HMS.Payment;
using HMS.People.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Patient_Charge.Control
{
    public partial class ctrlPatientChargeDetails : UserControl
    {
        public ctrlPatientChargeDetails()
        {
            InitializeComponent();
        }

        private clsPatientCharge _PatientChargeData;
        public clsPatientCharge PatientChargeData { get { return _PatientChargeData; } }

        private async void LoadEmptyScreen()
        {
            lblPaymentHistory.Enabled = false;
            lblID.Text = "???";
            lblServiceFees.Text = "???";
            lblDiscountedFees.Text = "???";
            lblTotalOriginalFees.Text = "???";
            lblDiscountPercentage.Text = "???";
            lblPaidFees.Text = "???";
            lblRemainingFees.Text = "???";
            lblStatus.Text = "???";
            lblAppointmentID.Text = "???";
            lblChargeServiceName.Text = "???";
            lblCreatedDate.Text = "???";
            lblCreatedBy.Text = "???";

            lblStatus.StateCommon.ShortText.Color1 = Color.Black;
        }

        private async void LoadDataScreen()
        {
            lblPaymentHistory.Enabled = true;
            lblID.Text = _PatientChargeData.ID.ToString() ?? "???";
            lblServiceFees.Text = _PatientChargeData.ServiceFees.ToString() ?? "???";
            lblDiscountedFees.Text = _PatientChargeData.DiscountedFees.ToString() ?? "???";
            lblTotalOriginalFees.Text = _PatientChargeData.TotalOriginalFees.ToString() ?? "???";
            lblDiscountPercentage.Text = _PatientChargeData.DiscountPercentage.ToString() + "%" ?? "???";
            lblPaidFees.Text = _PatientChargeData.PaidFees.ToString() ?? "???";
            lblRemainingFees.Text = _PatientChargeData.RemainingFees.ToString() ?? "???";
            lblStatus.Text = _PatientChargeData.Status == clsPatientCharge.enStatus.PartiallyPaid ? "Partially Paid" : _PatientChargeData.Status?.ToString() ?? "???";
            lblAppointmentID.Text = _PatientChargeData.AppointmentID.ToString() ?? "???";
            lblChargeServiceName.Text = _PatientChargeData.ChargeServiceName ?? "???";
            lblCreatedDate.Text = clsUtility.DateTimeFormat(_PatientChargeData.CreatedDate) ?? "???";
            lblCreatedBy.Text = _PatientChargeData.CreatedByUsername ?? "???";

            switch (_PatientChargeData.Status)
            {
                case clsPatientCharge.enStatus.Unpaid:
                    lblStatus.StateCommon.ShortText.Color1 = Color.Firebrick;
                    break;

                case clsPatientCharge.enStatus.PartiallyPaid:
                    lblStatus.StateCommon.ShortText.Color1 = Color.DarkOrange;
                    break;

                case clsPatientCharge.enStatus.Paid:
                    lblStatus.StateCommon.ShortText.Color1 = Color.ForestGreen;
                    break;

                case clsPatientCharge.enStatus.Cancelled:
                    lblStatus.StateCommon.ShortText.Color1 = Color.Gray;
                    break;
            }
        }

        public async Task LoadPatientChargeData(int PatientChargeid)
        {
            if (PatientChargeid > 0)
            {
                _PatientChargeData = await clsPatientCharge.Find(PatientChargeid);

                if (_PatientChargeData != null)
                    LoadDataScreen();
                else
                    LoadEmptyScreen();
            }
            else
            {
                _PatientChargeData = null;
                LoadEmptyScreen();
            }
        }
        
        public void LoadPatientChargeData(clsPatientCharge PatientCharge)
        {
            if (PatientCharge != null)
            {
                _PatientChargeData = PatientCharge;
                LoadDataScreen();
            }
            else
            {
                _PatientChargeData = null;
                LoadEmptyScreen();
            }
        }

        private void lblPaymentHistory_LinkClicked(object sender, EventArgs e)
        {
            frmPaymentsHistory frm = new frmPaymentsHistory(_PatientChargeData.ID, _PatientChargeData.Status.Value);
            frm.ShowDialog();
        }
    }
}
