using Common;
using HMS.BLL;
using HMS.Patients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Doctors.Controls
{
    public partial class ctrlDoctorDetails : UserControl
    {
        public ctrlDoctorDetails()
        {
            InitializeComponent();
            ctrlPersonDetails1.DisablePersonEdit();
        }

        private clsDoctor _DoctorData;
        public clsDoctor DoctorData { get { return _DoctorData; } }

        private async void LoadEmptyScreen()
        {
            lblEdit.Enabled = false;
            lblID.Text = "???";
            lblActive.Text = "???";
            lblActive.StateCommon.ShortText.Color1 = Color.Black;
            lblDepartment.Text = "???";
            lblSpecialization.Text = "???";
            lblCreatedDate.Text = "???";
            lblCreatedBy.Text = "???";
            ctrlPersonDetails1.LoadPersonData(null);
        }

        private async void LoadDataScreen()
        {
            lblEdit.Enabled = true;
            lblID.Text = _DoctorData.ID?.ToString() ?? "???";
            lblDepartment.Text = _DoctorData.Department.Name ?? "???";
            lblSpecialization.Text = _DoctorData.Specialization.Name ?? "???";
            lblCreatedDate.Text = clsUtility.DateTimeFormat(_DoctorData.CreatedDate) ?? "???";
            lblCreatedBy.Text = _DoctorData.CreatedByUsername ?? "???";
            ctrlPersonDetails1.LoadPersonData(_DoctorData.Person);

            if (_DoctorData.IsActive.HasValue)
            {
                if (_DoctorData.IsActive.Value)
                {
                    lblActive.Text = "Yes";
                    lblActive.StateCommon.ShortText.Color1 = Color.Green;
                }
                else
                {
                    lblActive.Text = "No";
                    lblActive.StateCommon.ShortText.Color1 = Color.Red;
                }
            }
            else
            {
                lblActive.Text = "???";
                lblActive.StateCommon.ShortText.Color1 = Color.Black;

            }

        }

        public async Task LoadDoctorData(int Doctorid)
        {
            if (Doctorid > 0)
            {
                _DoctorData = await clsDoctor.Find(Doctorid);

                if (_DoctorData != null)
                    LoadDataScreen();
                else
                    LoadEmptyScreen();
            }
            else
            {
                _DoctorData = null;
                LoadEmptyScreen();
            }
        }
        public void LoadDoctorData(clsDoctor Doctor)
        {
            if (Doctor != null)
            {
                _DoctorData = Doctor;
                LoadDataScreen();
            }
            else
            {
                _DoctorData = null;
                LoadEmptyScreen();
            }
        }

        private void lblEdit_LinkClicked(object sender, EventArgs e)
        {
            frmAddNewEditDoctor frm = new frmAddNewEditDoctor(_DoctorData);
            frm.OnDoctorDataSaved += LoadDoctorData;
            frm.ShowDialog();
        }
    }
}
