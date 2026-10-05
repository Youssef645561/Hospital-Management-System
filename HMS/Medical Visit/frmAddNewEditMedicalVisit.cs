using HMS.BLL;
using HMS.Lab_Test;
using HMS.People.Control;
using HMS.Prescription;
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

namespace HMS.Medical_Visit
{
    public partial class frmAddNewEditMedicalVisit : JOSubForm
    {
        public event Action<clsMedicalVisit> OnMedicalVisitDataSaved;

        int? ID { get; set; } = null;
        int? AppointmentID { get; set; }

        public enum enMode { AddNew, Edit }
        public enMode? _Mode;

        clsMedicalVisit _MedicalVisitData = null;

        public frmAddNewEditMedicalVisit()
        {
            InitializeComponent();
        }

        public void AddNewMedicalVisit(int? AppointmentID)
        {
            _Mode = enMode.AddNew;
            this.AppointmentID = AppointmentID;
        }

        public void EditMedicalVisit(int? ID)
        {
            _Mode = enMode.Edit;
            this.ID = ID;
        }

        public void EditMedicalVisit(clsMedicalVisit MedicalVisitData)
        {
            _Mode = enMode.Edit;
            this._MedicalVisitData = MedicalVisitData;
        }

        public async void frmAddNewEditMedicalVisit_Load(object sender, EventArgs e)
        {
            if (ID.HasValue)
                _MedicalVisitData = await clsMedicalVisit.Find(ID);

            if (_Mode == enMode.AddNew)
                ShowAddNewScreen();
            else
            {
                if (_MedicalVisitData != null)
                    ShowEditScreen();
                else
                    DisableScreen();
            }
        }

        public void lblTitle_SizeChanged(object sender, EventArgs e)
        {
            lblTitle.Left = (this.Width - lblTitle.Width) / 2;
        }

        public void ShowAddNewScreen()
        {
            _Mode = enMode.AddNew;
            _MedicalVisitData = new clsMedicalVisit();
            this.Text = lblTitle.Text = "Add New Medical Visit";
            gbMedicalVisitData.Values.Description = "ID : ???";
            lblAddPrescription.Visible = false;
            lblEditPrescription.Visible = false;
            lblRequestLabTest.Visible = false;
        }

        public void DisableScreen()
        {
            this._MedicalVisitData = null;
            gbMedicalVisitData.Enabled = btnSave.Enabled = false;
            lblAddPrescription.Visible = lblEditPrescription.Visible = false;
            MessageBox.Show("Medical Visit data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public async void ShowEditScreen()
        {
            _Mode = enMode.Edit;

            this.Text = lblTitle.Text = "Edit Medical Visit";

            if (_MedicalVisitData != null)
            {
                gbMedicalVisitData.Values.Description = $"ID : {_MedicalVisitData.ID}";
                AppointmentID = _MedicalVisitData.AppointmentID;

                tbSymptoms.Text = _MedicalVisitData.PatientSymptoms;
                tbDiagnosis.Text = _MedicalVisitData.Diagnosis;
                tbNotes.Text = _MedicalVisitData.Notes;

                if (_MedicalVisitData.PrescriptionID.HasValue)
                {
                    lblAddPrescription.Visible = false;
                    lblEditPrescription.Visible = true;
                }
                else
                {
                    lblAddPrescription.Visible = true;
                    lblEditPrescription.Visible = false;
                }

                lblRequestLabTest.Visible = true;

                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
                MessageBox.Show("No Medical Visit selected for editing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSymptoms.Text))
            {
                MessageBox.Show("Please enter the patient's symptoms.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSymptoms.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbDiagnosis.Text))
            {
                MessageBox.Show("Please enter the diagnosis.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbDiagnosis.Focus();
                return;
            }

            if (_Mode == enMode.AddNew)
            {
                _MedicalVisitData.CreatedByUserID = clsGlobal.CurrentUser.ID;
                _MedicalVisitData.CreatedByUsername = clsGlobal.CurrentUser.Username;
            }

            _MedicalVisitData.AppointmentID = AppointmentID;
            _MedicalVisitData.PatientSymptoms = tbSymptoms.Text.Trim();
            _MedicalVisitData.Diagnosis = tbDiagnosis.Text.Trim();
            _MedicalVisitData.Notes = string.IsNullOrWhiteSpace(tbNotes.Text) ? null : tbNotes.Text.Trim();

            if (await _MedicalVisitData.Save())
            {
                ShowEditScreen();
                OnMedicalVisitDataSaved?.Invoke(_MedicalVisitData);
                MessageBox.Show("Medical Visit data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Failed to save Medical Visit data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAddPrescription_LinkClicked(object sender, EventArgs e)
        {
            frmAddNewEditPrescription frm = new frmAddNewEditPrescription();
            frm.LoadMedicalVisitData(_MedicalVisitData);
            frm.OnPrescriptionDataSaved += (clsPrescription PrescriptionData) =>
            {
                _MedicalVisitData.PrescriptionID = PrescriptionData.ID;
                ShowEditScreen();
            };
            frm.ShowDialog();
        }

        private void lblEditPrescription_LinkClicked(object sender, EventArgs e)
        {
            frmAddNewEditPrescription frm = new frmAddNewEditPrescription(_MedicalVisitData.PrescriptionID);
            frm.LoadMedicalVisitData(_MedicalVisitData);
            frm.ShowDialog();
        }

        private void lblRequestLabTest_LinkClicked(object sender, EventArgs e)
        {
            frmAddNewEditLabTest frm = new frmAddNewEditLabTest(AppointmentID);
            frm.ShowDialog();
        }
    }
}
