using HMS.BLL;
using HMS.Patients.Controls;
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

namespace HMS.Patients
{
    public partial class frmAddNewEditPatient : JOSubForm
    {
        public event Action<clsPatient> OnPatientDataSaved;

        int? ID { get; set; } = null;
        public enum enMode { AddNew, Edit }
        private enMode? _Mode;

        clsPatient _PatientData = null;

        public frmAddNewEditPatient()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddNewEditPatient(int? ID)
        {
            InitializeComponent();
            _Mode = enMode.Edit;
            this.ID = ID;
        }
        public frmAddNewEditPatient(clsPatient PatientData)
        {
            InitializeComponent();
            _Mode = enMode.Edit;
            this._PatientData = PatientData;
        }

        private async void PersonSelected(clsPerson person)
        {
            if (!await clsPatient.IsExist(person.ID))
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
                MessageBox.Show("The selected person is already registered as a patient.", "Duplicate Patient", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void frmAddNewEditPatient_Load(object sender, EventArgs e)
        {
            ctrlPersonDetailsSelector1.OnPersonSelected += PersonSelected;

            if (ID.HasValue)
                _PatientData = await clsPatient.Find(ID);

            if (_Mode == enMode.AddNew)
                ShowAddNewScreen();
            else
            {
                if (_PatientData != null)
                    ShowEditScreen();
                else
                    DisableScreen();
            }
        }

        private void lblTitle_SizeChanged(object sender, EventArgs e)
        {
            lblTitle.Left = (this.Width - lblTitle.Width) / 2;
        }

        private void ShowAddNewScreen()
        {
            _Mode = enMode.AddNew;
            _PatientData = new clsPatient();
            this.Text = lblTitle.Text = "Add New Patient";
            gbPatientData.Values.Description = "ID : ???";
            lblMedicalRecordNo.Text = "???";
            btnSave.Enabled = false;
            ctrlPersonDetailsSelector1.EnableFilter();
        }
        private void DisableScreen()
        {
            this._PatientData = null;
            gbPatientData.Enabled = btnSave.Enabled = false;
            ctrlPersonDetailsSelector1.Enabled = false;
            MessageBox.Show("Patient data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void ShowEditScreen()
        {
            _Mode = enMode.Edit;

            this.Text = lblTitle.Text = "Edit Patient";

            if (_PatientData != null)
            {
                ctrlPersonDetailsSelector1.DisableFilter();
                gbPatientData.Values.Description = $"ID : {_PatientData.ID}";
                lblMedicalRecordNo.Text = _PatientData.MedicalRecordNo;
                cbBloodType.Text = _PatientData.BloodType;

                if (ctrlPersonDetailsSelector1.PersonData == null)
                    await ctrlPersonDetailsSelector1.LoadPersonData(_PatientData.PersonID);

                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
                MessageBox.Show("No patient selected for editing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ctrlPersonDetailsSelector1.PersonData != null)
            {
                _PatientData.PersonID = ctrlPersonDetailsSelector1.PersonData.ID;
                _PatientData.Person = ctrlPersonDetailsSelector1.PersonData;
                if (_Mode == enMode.AddNew)
                {
                    _PatientData.CreatedByUserID = clsGlobal.CurrentUser.ID;
                    _PatientData.CreatedByUsername = clsGlobal.CurrentUser.Username;
                }

                _PatientData.BloodType = cbBloodType.Text;

                if (await _PatientData.Save())
                {
                    ShowEditScreen();
                    OnPatientDataSaved?.Invoke(_PatientData);
                    MessageBox.Show("Patient data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Failed to save patient data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please select a person before saving.", "No Person Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _PatientData.Person = ctrlPersonDetailsSelector1.PersonData;
            OnPatientDataSaved?.Invoke(_PatientData);
            this.Close();
        }
    }
}
