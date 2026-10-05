using Common;
using HMS.Appointment;
using HMS.BLL;
using HMS.People.Control;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS.Medical_Visit.Control
{
    public partial class ctrlMedicalVisitDetails : UserControl
    {
        private clsMedicalVisit _MedicalVisitData;
        public clsMedicalVisit MedicalVisitData { get { return _MedicalVisitData; } }

        public ctrlMedicalVisitDetails()
        {
            InitializeComponent();

            tbSymptoms.Enabled = tbDiagnosis.Enabled = tbNotes.Enabled = false;
            tbSymptoms.Multiline = tbDiagnosis.Multiline = tbNotes.Multiline = true;
            tbSymptoms.WordWrap = tbDiagnosis.WordWrap = tbNotes.WordWrap = true;
            tbSymptoms.ScrollBars = tbDiagnosis.ScrollBars = tbNotes.ScrollBars = ScrollBars.None;

            tbSymptoms.StateDisabled.Back.Color1 = tbDiagnosis.StateDisabled.Back.Color1 = tbNotes.StateDisabled.Back.Color1 = Color.White;
            //tbSymptoms.StateDisabled.Border.Draw = tbDiagnosis.StateDisabled.Border.Draw = tbNotes.StateDisabled.Border.Draw = InheritBool.False;
            tbSymptoms.StateDisabled.Content.Color1 = tbDiagnosis.StateDisabled.Content.Color1 = tbNotes.StateDisabled.Content.Color1 = this.ForeColor;
        }

        public void DisableMedicalVisitEdit()
        {
            lblEdit.Visible = false;
        }

        private async void LoadEmptyScreen()
        {
            lblEdit.Enabled = lblAppointmentDetails.Enabled = false;
            lblID.Text = "???";
            tbSymptoms.Text = "???";
            tbDiagnosis.Text = "???";
            tbNotes.Text = "???";
            lblAppointmentID.Text = "???";
            lblCreatedDate.Text = "???";
            lblCreatedBy.Text = "???";
        }

        private async void LoadDataScreen()
        {
            lblEdit.Enabled = lblAppointmentDetails.Enabled = true;
            lblID.Text = _MedicalVisitData.ID?.ToString() ?? "???";
            tbSymptoms.Text = _MedicalVisitData.PatientSymptoms ?? "???";
            tbDiagnosis.Text = _MedicalVisitData.Diagnosis ?? "???";
            tbNotes.Text = _MedicalVisitData.Notes ?? "???";
            lblAppointmentID.Text = _MedicalVisitData.AppointmentID.ToString() ?? "???";
            lblCreatedDate.Text = clsUtility.DateTimeFormat(_MedicalVisitData.CreatedDate) ?? "???";
            lblCreatedBy.Text = _MedicalVisitData.CreatedByUsername ?? "???";
        }

        public async Task LoadMedicalVisitData(int id)
        {
            if (id > 0)
            {
                _MedicalVisitData = await clsMedicalVisit.Find(id);

                if (_MedicalVisitData != null)
                    LoadDataScreen();
                else
                    LoadEmptyScreen();
            }
            else
            {
                _MedicalVisitData = null;
                LoadEmptyScreen();
            }
        }

        public void LoadMedicalVisitData(clsMedicalVisit MedicalVisit)
        {
            if (MedicalVisit != null)
            {
                _MedicalVisitData = MedicalVisit;
                LoadDataScreen();
            }
            else
            {
                _MedicalVisitData = null;
                LoadEmptyScreen();
            }
        }

        private void lblEdit_LinkClicked(object sender, EventArgs e)
        {
            frmAddNewEditMedicalVisit frm = new frmAddNewEditMedicalVisit();
            frm.EditMedicalVisit(_MedicalVisitData);
            frm.OnMedicalVisitDataSaved += LoadMedicalVisitData;
            frm.ShowDialog(); 
        }

        private void lblAppointmentDetails_LinkClicked(object sender, EventArgs e)
        {
            frmAppointmentDetails frm = new frmAppointmentDetails(_MedicalVisitData.AppointmentID.Value);
            frm.ShowDialog();
        }
    }

}
