using Common;
using HMS.BLL;
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

namespace HMS.Prescription.Control
{
    public partial class ctrlPrescriptionDetails : UserControl
    {
        public ctrlPrescriptionDetails()
        {
            InitializeComponent();
        }

        private clsPrescription _PrescriptionData;
        public clsPrescription PrescriptionData { get { return _PrescriptionData; } }

        private async void LoadEmptyScreen()
        {
            lblEdit.Enabled = false;
            lblID.Text = "???";
            lblExpirationDate.Text = "???";
            lblStatus.StateCommon.ShortText.Color1 = Color.Black;
            lblStatus.Text = "???";
            lblMedicalVisitID.Text = "???";
            lblCreatedBy.Text = "???";
        }

        private async void LoadDataScreen()
        {
            lblEdit.Enabled = true;
            lblID.Text = _PrescriptionData.ID?.ToString() ?? "???";
            lblExpirationDate.Text = clsUtility.DateFormat(_PrescriptionData.ExpirationDate) ?? "???";
            lblStatus.Text = _PrescriptionData.Status.ToString() ?? "???";
            lblMedicalVisitID.Text = _PrescriptionData.MedicalVisitID.ToString() ?? "???";
            lblCreatedBy.Text = _PrescriptionData.CreatedByUsername ?? "???";

            if (_PrescriptionData.Status.HasValue)
            {
                if (_PrescriptionData.Status == clsPrescription.enStatus.Active)
                {
                    lblStatus.StateCommon.ShortText.Color1 = Color.Green;
                }
                else
                {
                    lblStatus.StateCommon.ShortText.Color1 = Color.Red;
                }
            }
            else
            {
                lblStatus.Text = "???";
                lblStatus.StateCommon.ShortText.Color1 = Color.Black;
            }

        }

        public async Task LoadPrescriptionData(int Prescriptionid)
        {
            if (Prescriptionid > 0)
            {
                _PrescriptionData = await clsPrescription.Find(Prescriptionid);

                if (_PrescriptionData != null)
                    LoadDataScreen();
                else
                    LoadEmptyScreen();
            }
            else
            {
                _PrescriptionData = null;
                LoadEmptyScreen();
            }
        }
        public void LoadPrescriptionData(clsPrescription Prescription)
        {
            if (Prescription != null)
            {
                _PrescriptionData = Prescription;
                LoadDataScreen();
            }
            else
            {
                _PrescriptionData = null;
                LoadEmptyScreen();
            }
        }

        private void lblEdit_LinkClicked(object sender, EventArgs e)
        {
            frmAddNewEditPrescription frm = new frmAddNewEditPrescription(_PrescriptionData);
            frm.OnPrescriptionDataSaved += LoadPrescriptionData;
            frm.ShowDialog();
        }
    }
}
