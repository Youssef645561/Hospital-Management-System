using HMS.BLL;
using HMS.Patient.Control;
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
using Youssef.WinForms.Controls;

namespace HMS.Patient_Charge
{
    public partial class frmAddNewEditPatientCharge : JOSubForm
    {
        bool IsChargeServicesLoading = false;
        bool IsPatientChargeLoading = false, IsTestTypesLoading = false;

        public enum enMode { AddNew, Edit }
        enMode _Mode;

        int? ID = null;
        decimal ServiceFees = 0, TotalOriginalFees = 0, FinalFees = 0;
        byte DiscountPerc = 0;

        clsPatientCharge _PatientChargeData = null;

        public event Action<clsPatientCharge> OnPatientChargeDataSaved;

        public frmAddNewEditPatientCharge()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public async Task LoadAppointmentDate(int? AppointmentID)
        {
            await ctrlAppointmentDetailsSelector1.LoadAppointmentData(AppointmentID);
        }

        private void DisableScreen()
        {
            this._PatientChargeData = null;
            gbPatientChargeData.Enabled = btnSave.Enabled = false;
            MessageBox.Show("Patient Charge data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowAddNewScreen()
        {
            _Mode = enMode.AddNew;
            _PatientChargeData = new clsPatientCharge();
            lblTitle.Text = this.Text = "Add New Patient Charge";

            lblOriginalFees.Text = lblFinalFees.Text = "0";

            cbChargeServices_SelectedIndexChanged(null, null);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrlAppointmentDetailsSelector1.AppointmentData != null)
                tcAddNewEditPatientCharge.SelectedTab = tpPatientChargeData;
            else
                MessageBox.Show("Please select an appointment first.", "Appointment Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcAddNewEditPatientCharge.SelectedTab = tpAppointmentData;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ctrlAppointmentDetailsSelector1.AppointmentData == null)
            {
                MessageBox.Show("Please select an appointment first.", "Appointment Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (await clsPatientCharge.IsExist(ctrlAppointmentDetailsSelector1.AppointmentData.ID, (short)cbChargeServices.SelectedValue, cbTestTypes.Visible ? (byte?)Convert.ToByte(cbTestTypes.SelectedValue) : null))
            {
                MessageBox.Show("This service has already been added to this appointment.", "Service Already Added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _PatientChargeData.ServiceFees = ServiceFees;
            _PatientChargeData.TotalOriginalFees = TotalOriginalFees;
            _PatientChargeData.DiscountPercentage = DiscountPerc;
            _PatientChargeData.AppointmentID = ctrlAppointmentDetailsSelector1.AppointmentData.ID;
            _PatientChargeData.ChargeServiceID = (short?)cbChargeServices.SelectedValue;
            _PatientChargeData.TestTypeID = cbTestTypes.Visible ? (byte?)Convert.ToByte(cbTestTypes.SelectedValue) : null;
            _PatientChargeData.CreatedByUserID = clsGlobal.CurrentUser.ID;

            if (await _PatientChargeData.Save())
            {
                OnPatientChargeDataSaved?.Invoke(_PatientChargeData);

                MessageBox.Show("Patient Charge saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Failed to save Patient Charge . Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task LoadChargeServices()
        {
            IsChargeServicesLoading = true;

            cbChargeServices.DataSource = await clsChargeService.GetAll();
            cbChargeServices.DisplayMember = "Name";
            cbChargeServices.ValueMember = "ID";

            IsChargeServicesLoading = false;
        }

        private async Task LoadTestTypes()
        {
            IsTestTypesLoading = true;

            cbTestTypes.DataSource = await clsTestType.GetAll();
            cbTestTypes.DisplayMember = "Name";
            cbTestTypes.ValueMember = "ID";

            IsTestTypesLoading = false;
        }

        private async void frmAddNewEditPatientCharge_Load(object sender, EventArgs e)
        {
            tcAddNewEditPatientCharge.Appearance = TabAppearance.FlatButtons;
            tcAddNewEditPatientCharge.ItemSize = new Size(0, 1);
            tcAddNewEditPatientCharge.SizeMode = TabSizeMode.Fixed;

            await LoadChargeServices();
            await LoadTestTypes();

            if (ID.HasValue)
                _PatientChargeData = await clsPatientCharge.Find(ID);

            if (_Mode == enMode.AddNew)
                ShowAddNewScreen();
            else
            {
                if (_PatientChargeData == null)
                    DisableScreen();
            }
        }

        private void cbChargeServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsChargeServicesLoading)
            {
                lblTestType.Visible = cbTestTypes.Visible = (cbChargeServices.Text.Trim() == "Lab Test");

                if (decimal.TryParse((((DataRowView)cbChargeServices.SelectedItem)["Fees"]?.ToString()), out ServiceFees))
                {
                    TotalOriginalFees = ServiceFees;

                    if (cbTestTypes.Visible)
                    {
                        TotalOriginalFees += decimal.Parse((((DataRowView)cbTestTypes.SelectedItem)["Fees"]?.ToString()));
                    }

                    lblOriginalFees.Text = TotalOriginalFees.ToString();

                    if (!string.IsNullOrWhiteSpace(tbDiscountPercentage.Text))
                    {
                        DiscountPerc = byte.Parse(tbDiscountPercentage.Text);
                        FinalFees = (TotalOriginalFees * (1 - DiscountPerc / 100m));

                        lblFinalFees.Text = FinalFees.ToString();
                    }
                    else
                        lblFinalFees.Text = lblOriginalFees.Text;
                }
                else
                    lblOriginalFees.Text = lblFinalFees.Text = "0";
            }
        }

        private void cbTestTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsTestTypesLoading)
            {
                cbChargeServices_SelectedIndexChanged(sender, e);
            }
        }

        private void tbDiscountPercentage_TextChanged(object sender, EventArgs e)
        {
            if (!IsPatientChargeLoading)
            {
                if (!string.IsNullOrWhiteSpace(tbDiscountPercentage.Text))
                {
                    DiscountPerc = byte.Parse(tbDiscountPercentage.Text);
                    FinalFees = (TotalOriginalFees * (1 - DiscountPerc / 100m));
                    lblFinalFees.Text = FinalFees.ToString();
                }
                else
                {
                    DiscountPerc = 0;
                    FinalFees = TotalOriginalFees;
                    lblFinalFees.Text = lblOriginalFees.Text;
                }
            }
        }
    }
}