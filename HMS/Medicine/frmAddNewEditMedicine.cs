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
using Youssef.WinForms.Controls;

namespace HMS.Medicine
{
    public partial class frmAddNewEditMedicine : JOSubForm
    {
        public event Action<clsMedicine> OnMedicineDataSaved;

        int? ID { get; set; } = null;
        public enum enMode { AddNew, Edit }
        private enMode? _Mode = null;

        clsMedicine _MedicineData = null;

        public frmAddNewEditMedicine()
        {
            InitializeComponent();
            ShowAddNewScreen();
        }
        public frmAddNewEditMedicine(int? ID)
        {
            InitializeComponent();
            this.ID = ID;
        }
        public frmAddNewEditMedicine(clsMedicine Medicine)
        {
            InitializeComponent();
            this._MedicineData = Medicine;
        }

        private async void frmAddNewEditMedicine_Load(object sender, EventArgs e)
        {
            cbDosageForms.DataSource = Enum.GetValues(typeof(clsMedicine.enDosageForm));
            
            if (_Mode != enMode.AddNew)
            {
                if (_MedicineData == null)
                {
                    if (ID.HasValue)
                        _MedicineData = await clsMedicine.Find(ID);
                }

                ShowEditScreen();
            }
        }

        private void lblTitle_SizeChanged(object sender, EventArgs e)
        {
            lblTitle.Left = (this.Width - lblTitle.Width) / 2;
        }

        private void ShowAddNewScreen()
        {
            _Mode = enMode.AddNew;
            _MedicineData = new clsMedicine();
            this.Text = lblTitle.Text = "Add New Medicine";
            gbMedicineData.Values.Description = "ID : ???";
            btnSave.Enabled = true;
        }

        private async void ShowEditScreen()
        {
            _Mode = enMode.Edit;

            this.Text = lblTitle.Text = "Edit Medicine";

            if (_MedicineData != null)
            {
                gbMedicineData.Values.Description = $"ID : {_MedicineData.ID}";
                tbName.Text = _MedicineData.Name;
                tbStrength.Text = _MedicineData.Strength.Substring(0, (_MedicineData.Strength.Length - 3)).Trim();
                cbDosageForms.SelectedItem = _MedicineData.DosageForm;
                tbDescription.Text = _MedicineData.Description;
                ckActive.Checked = _MedicineData.IsActive.Value;

                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
                MessageBox.Show("No Medicine selected for editing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                _MedicineData.CreatedByUserID = clsGlobal.CurrentUser.ID;
                _MedicineData.CreatedByUsername = clsGlobal.CurrentUser.Username;
            }

            _MedicineData.Name = tbName.Text;
            _MedicineData.Strength = tbStrength.Text.Trim() + " mg";
            _MedicineData.DosageForm = (clsMedicine.enDosageForm)cbDosageForms.SelectedItem;
            _MedicineData.Description = string.IsNullOrEmpty(tbDescription.Text) ? null : tbDescription.Text;
            _MedicineData.IsActive = ckActive.Checked;

            if (await _MedicineData.Save())
            {
                ShowEditScreen();
                OnMedicineDataSaved?.Invoke(_MedicineData);
                MessageBox.Show("Medicine data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Failed to save Medicine data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
