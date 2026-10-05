using HMS.BLL;
using HMS.Patient_Charge.Control;
using HMS.People.Control;
using Krypton.Toolkit;
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

namespace HMS.Payment
{
    public partial class frmAddNewEditPayment : JOSubForm
    {
        bool IsPaymentMethodsLoading = false;

        public event Action<clsPatientCharge> OnPaymentDataSaved;


        int? ID { get; set; } = null;
        decimal PaidAmount = 0, Change = 0;

        public enum enMode { AddNew, Edit }
        private enMode? _Mode;

        clsPayment _PaymentData = null;

        public frmAddNewEditPayment()
        {
            InitializeComponent();
            ctrlPatientChargeDetailsSelector1.OnPatientChargeSelected += PatientChargeSelected;
            _Mode = enMode.AddNew;
        }

        private async void PatientChargeSelected(clsPatientCharge PatientCharge)
        {
            if (PatientCharge.Status == clsPatientCharge.enStatus.Paid)
            {
                btnSave.Enabled = false;
                MessageBox.Show("This charge cannot be paid because it has already been paid.", "Payment Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(PatientCharge.Status == clsPatientCharge.enStatus.Cancelled)
            {
                btnSave.Enabled = false;
                MessageBox.Show("This charge cannot be paid because it has already been cancelled.", "Payment Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        public async Task LoadPatientCharge(int PatientChargeID)
        {
            await ctrlPatientChargeDetailsSelector1.LoadPatientChargeData(PatientChargeID);
        }

        private async void frmAddNewEditPayment_Load(object sender, EventArgs e)
        {

            cbPaymentMethods.DataSource = Enum.GetValues(typeof(clsPayment.enMethod));

            if (ID.HasValue)
                _PaymentData = await clsPayment.Find(ID);

            if (_Mode == enMode.AddNew)
                ShowAddNewScreen();
            else
            {
                if (_PaymentData == null)
                    DisableScreen();
            }
        }

        private void ShowAddNewScreen()
        {
            _Mode = enMode.AddNew;
            _PaymentData = new clsPayment();
            this.Text = lblTitle.Text = "Add New Payment";
        }

        private void DisableScreen()
        {
            this._PaymentData = null;
            gbPaymentData.Enabled = btnSave.Enabled = false;
            ctrlPatientChargeDetailsSelector1.Enabled = false;
            MessageBox.Show("Payment data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ctrlPatientChargeDetailsSelector1.PatientChargeData != null)
            {
                PaidAmount = Convert.ToDecimal(tbPaidAmount.Text);

                if (PaidAmount > ctrlPatientChargeDetailsSelector1.PatientChargeData.RemainingFees)
                {
                    Change = Convert.ToDecimal(PaidAmount - ctrlPatientChargeDetailsSelector1.PatientChargeData.RemainingFees);
                    PaidAmount -= Change;
                }

                _PaymentData.PaidAmount = PaidAmount;
                _PaymentData.Method = (clsPayment.enMethod)cbPaymentMethods.SelectedItem;
                _PaymentData.PatientChargeID = ctrlPatientChargeDetailsSelector1.PatientChargeData.ID;
                _PaymentData.CreatedByUserID = clsGlobal.CurrentUser.ID;
                _PaymentData.CreatedByUsername = clsGlobal.CurrentUser.Username;

                if (await _PaymentData.Save())
                {
                    ctrlPatientChargeDetailsSelector1.PatientChargeData.PaidFees += PaidAmount;
                    ctrlPatientChargeDetailsSelector1.PatientChargeData.RemainingFees -= PaidAmount;

                    if (ctrlPatientChargeDetailsSelector1.PatientChargeData.RemainingFees == 0)
                        ctrlPatientChargeDetailsSelector1.PatientChargeData.Status = clsPatientCharge.enStatus.Paid;
                    else if (ctrlPatientChargeDetailsSelector1.PatientChargeData.RemainingFees > 0)
                        ctrlPatientChargeDetailsSelector1.PatientChargeData.Status = clsPatientCharge.enStatus.PartiallyPaid;
                    else if (ctrlPatientChargeDetailsSelector1.PatientChargeData.RemainingFees == ctrlPatientChargeDetailsSelector1.PatientChargeData.DiscountedFees)
                        ctrlPatientChargeDetailsSelector1.PatientChargeData.Status = clsPatientCharge.enStatus.Unpaid;

                    OnPaymentDataSaved?.Invoke(ctrlPatientChargeDetailsSelector1.PatientChargeData);

                    MessageBox.Show($"Payment data saved successfully.\nPayment ID: {_PaymentData.ID}\nTransaction No: {_PaymentData.TransactionNo}\nChange: {Change}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Failed to save Payment data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please select a Patient Charge before saving.", "No Payment Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //_PaymentData.PatientCharge = ctrlPatientChargeDetailsSelector1.PatientChargeData;
            //OnPaymentDataSaved?.Invoke(_PaymentData);
            this.Close();
        }

        private void tbPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox)sender;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            // منع أكثر من decimal point
            if (e.KeyChar == '.' && textBox.Text.Contains('.'))
            {
                e.Handled = true;
                return;
            }

            // منع أكثر من رقمين بعد decimal point
            if (char.IsDigit(e.KeyChar) && textBox.Text.Contains('.') && textBox.SelectionStart > textBox.Text.IndexOf('.') && textBox.Text.Substring(textBox.Text.IndexOf('.') + 1).Length >= 2 && textBox.SelectionLength == 0)
            {
                e.Handled = true;
            }
        }
    }
}
