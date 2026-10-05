using Common;
using HMS.Appointment;
using HMS.BLL;
using HMS.Patient_Charge;
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

namespace HMS.Lab_Test.Control
{
    public partial class ctrlLabTestDetails : UserControl
    {
        public ctrlLabTestDetails()
        {
            InitializeComponent();
            tbNotes.Enabled = false;
            tbNotes.Multiline = true;
            tbNotes.WordWrap = true;
            tbNotes.ScrollBars = ScrollBars.None;
            tbNotes.StateDisabled.Back.Color1 = Color.White;
            tbNotes.StateDisabled.Content.Color1 = this.ForeColor;
        }

        private clsLabTest _LabTestData;
        public clsLabTest LabTestData { get { return _LabTestData; } }

        private Color GetStatusColor(clsLabTest.enStatus? status)
        {
            switch (status)
            {
                case clsLabTest.enStatus.Pending:
                    return Color.DarkOrange;

                case clsLabTest.enStatus.InProgress:
                    return Color.RoyalBlue;

                case clsLabTest.enStatus.Completed:
                    return Color.ForestGreen;

                case clsLabTest.enStatus.Cancelled:
                    return Color.Firebrick;
                default:
                    return Color.Black;
            }
        }

        private Color GetResultColor(bool? result)
        {
            if (result == true)
                return Color.Green;
            else if (result == false)
                return Color.Red;
            else
                return Color.DarkOrange;
        }

        private async void LoadEmptyScreen()
        {
            lblAppointmentDetails.Enabled = lblPatientChargeDetails.Enabled = false;
            lblID.Text = "???";
            lblStatus.Text = "???";
            lblTestType.Text = "???";
            tbNotes.Text = "???";
            lblResult.Text = "???";
            lblResultDate.Text = "???";
            lblCreatedDate.Text = "???";
            lblCreatedBy.Text = "???";

            lblStatus.StateCommon.ShortText.Color1 = Color.Black;
            lblResult.StateCommon.ShortText.Color1 = Color.Black;
        }

        private async void LoadDataScreen()
        {
            lblAppointmentDetails.Enabled = lblPatientChargeDetails.Enabled = true;
            lblID.Text = _LabTestData.ID?.ToString() ?? "???";
            lblStatus.Text = _LabTestData.Status?.ToString() ?? "???";
            lblTestType.Text = _LabTestData.TestTypeName ?? "???";
            tbNotes.Text = _LabTestData.Notes ?? "No Notes";
            lblResult.Text = _LabTestData.Result.HasValue ? _LabTestData.Result.Value ? "Positive" : "Negative" : "No Result Yet";
            lblResultDate.Text = clsUtility.DateTimeFormat(_LabTestData.ResultDate) ?? "???";
            lblCreatedDate.Text = clsUtility.DateTimeFormat(_LabTestData.CreatedDate) ?? "???";
            lblCreatedBy.Text = _LabTestData.CreatedByUsername ?? "???";

            lblStatus.StateCommon.ShortText.Color1 = GetStatusColor(_LabTestData.Status ?? null);
            lblResult.StateCommon.ShortText.Color1 = GetResultColor(_LabTestData.Result ?? null);
        }

        public async Task LoadLabTestData(int LabTestid)
        {
            if (LabTestid > 0)
            {
                _LabTestData = await clsLabTest.Find(LabTestid);

                if (_LabTestData != null)
                    LoadDataScreen();
                else
                    LoadEmptyScreen();
            }
            else
            {
                _LabTestData = null;
                LoadEmptyScreen();
            }
        }

        public void LoadLabTestData(clsLabTest LabTest)
        {
            if (LabTest != null)
            {
                _LabTestData = LabTest;
                LoadDataScreen();
            }
            else
            {
                _LabTestData = null;
                LoadEmptyScreen();
            }
        }

        private void lblAppointmentDetails_LinkClicked(object sender, EventArgs e)
        {
            frmAppointmentDetails frm = new frmAppointmentDetails(_LabTestData.AppointmentID.Value);
            frm.ShowDialog();
        }

        private void lblPatientChargeDetails_LinkClicked(object sender, EventArgs e)
        {
            frmPatientChargeDetails frm = new frmPatientChargeDetails(_LabTestData.PatientChargeID.Value);
            frm.ShowDialog();
        }
    }
}
