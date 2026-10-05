using Common;
using HMS.Appointment;
using HMS.BLL;
using HMS.People.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Patients.Controls
{
    public partial class ctrlPatientDetails : UserControl
    {
        private clsPatient _PatientData;
        public clsPatient PatientData { get { return _PatientData; } }

        public ctrlPatientDetails()
        {
            InitializeComponent();
            ctrlPersonDetails1.DisablePersonEdit();
        }

        public void DisablePatientEdit()
        {
            lblEdit.Visible = false;
        }

        private async void LoadEmptyScreen()
        {
            lblPatientAppointmentsHistory.Enabled = lblEdit.Enabled = false;
            lblID.Text = "???";
            lblMedicalRecordNo.Text = "???";
            lblBloodType.Text = "???";
            lblCreatedDate.Text = "???";
            lblCreatedBy.Text = "???";
            ctrlPersonDetails1.LoadPersonData(null);
        }

        private async void LoadDataScreen()
        {
            lblPatientAppointmentsHistory.Enabled = lblEdit.Enabled = true;
            lblID.Text = _PatientData.ID?.ToString() ?? "???";
            lblMedicalRecordNo.Text = _PatientData.MedicalRecordNo ?? "???";
            lblBloodType.Text = _PatientData.BloodType ?? "???";
            lblCreatedDate.Text = clsUtility.DateTimeFormat(_PatientData.CreatedDate) ?? "???";
            lblCreatedBy.Text = _PatientData.CreatedByUsername ?? "???";
            ctrlPersonDetails1.LoadPersonData(_PatientData.Person);
        }

        public async Task LoadPatientData(int id)
        {
            if (id > 0)
            {
                _PatientData = await clsPatient.Find(id);

                if (_PatientData != null)
                    LoadDataScreen();
                else
                    LoadEmptyScreen();
            }
            else
            {
                _PatientData = null;
                LoadEmptyScreen();
            }
        }

        public async Task LoadPatientData(string medicalrecordno)
        {
            if (!string.IsNullOrEmpty(medicalrecordno))
            {
                _PatientData = await clsPatient.Find(medicalrecordno);

                if (_PatientData != null)
                    LoadDataScreen();
                else
                    LoadEmptyScreen();
            }
            else
            {
                _PatientData = null;
                LoadEmptyScreen();
            }
        }

        public void LoadPatientData(clsPatient patient)
        {
            if (patient != null)
            {
                _PatientData = patient;
                LoadDataScreen();
            }
            else
            {
                _PatientData = null;
                LoadEmptyScreen();
            }
        }

        private void lblEdit_LinkClicked(object sender, EventArgs e)
        {
            frmAddNewEditPatient frm = new frmAddNewEditPatient(_PatientData);
            frm.OnPatientDataSaved += LoadPatientData;
            frm.ShowDialog();
        }

        private void lblPatientAppointmentsHistory_LinkClicked(object sender, EventArgs e)
        {
            frmPatientAppointmentsHistory frm = new frmPatientAppointmentsHistory(_PatientData.ID);
            frm.ShowDialog();
        }

    }
}
