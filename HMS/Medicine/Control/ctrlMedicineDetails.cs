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

namespace HMS.Medicine.Control
{
    public partial class ctrlMedicineDetails : UserControl
    {
        public ctrlMedicineDetails()
        {
            InitializeComponent();
        }

        private clsMedicine _MedicineData;
        public clsMedicine MedicineData { get { return _MedicineData; } }

        private async void LoadEmptyScreen()
        {
            lblID.Text = "???";
            lblName.Text = "???";
            lblDosageForm.Text = "???";
            lblActive.Text = "???";
            lblActive.StateCommon.ShortText.Color1 = Color.Black;
            lblDescription.Text = "???";
            lblStrength.Text = "???";
            lblCreatedDate.Text = "???";
            lblCreatedBy.Text = "???";
        }

        private async void LoadDataScreen()
        {
            lblID.Text = _MedicineData.ID?.ToString() ?? "???";
            lblName.Text = _MedicineData.Name ?? "???";
            lblDosageForm.Text = _MedicineData.DosageForm.ToString() ?? "???";
            lblDescription.Text = _MedicineData?.Description ?? "No Description";
            lblStrength.Text = _MedicineData.Strength ?? "???";
            lblCreatedDate.Text = clsUtility.DateTimeFormat(_MedicineData.CreatedDate) ?? "???";
            lblCreatedBy.Text = _MedicineData.CreatedByUsername ?? "???";

            if (_MedicineData.IsActive.HasValue)
            {
                if (_MedicineData.IsActive.Value)
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

        public async Task LoadMedicineData(int Medicineid)
        {
            if (Medicineid > 0)
            {
                _MedicineData = await clsMedicine.Find(Medicineid);

                if (_MedicineData != null)
                    LoadDataScreen();
                else
                    LoadEmptyScreen();
            }
            else
            {
                _MedicineData = null;
                LoadEmptyScreen();
            }
        }

        public void LoadMedicineData(clsMedicine Medicine)
        {
            if (Medicine != null)
            {
                _MedicineData = Medicine;
                LoadDataScreen();
            }
            else
            {
                _MedicineData = null;
                LoadEmptyScreen();
            }
        }

        private void lblEdit_LinkClicked(object sender, EventArgs e)
        {
            frmAddNewEditMedicine frm = new frmAddNewEditMedicine(_MedicineData);
            frm.OnMedicineDataSaved +=  LoadMedicineData;
            frm.ShowDialog();
        }
    }
}
