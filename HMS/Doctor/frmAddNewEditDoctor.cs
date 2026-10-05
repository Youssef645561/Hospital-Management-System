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
using Youssef.WinForms.Controls;

namespace HMS.Doctors
{
    public partial class frmAddNewEditDoctor : JOSubForm
    {
        public enum enMode { AddNew, Edit }
        enMode _Mode;

        int? ID = null;

        clsDoctor _DoctorData = null;

        public event Action<clsDoctor> OnDoctorDataSaved;

        public frmAddNewEditDoctor()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddNewEditDoctor(int? ID)
        {
            InitializeComponent();
            _Mode = enMode.Edit;
            this.ID = ID;
        }
        public frmAddNewEditDoctor(clsDoctor DoctorData)
        {
            InitializeComponent();
            _Mode = enMode.Edit;
            this._DoctorData = DoctorData;
        }

        private async void PersonSelected(clsPerson Person)
        {
            if (!await clsDoctor.IsExist(Person.ID))
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
                MessageBox.Show("The selected person is already registered as a doctor.", "Duplicate doctor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblTitle_SizeChanged(object sender, EventArgs e)
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
        }

        private void DisableScreen()
        {
            this._DoctorData = null;
            gbDoctorData.Enabled = btnSave.Enabled = false;
            MessageBox.Show("Doctor data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowAddNewScreen()
        {
            _Mode = enMode.AddNew;
            _DoctorData = new clsDoctor();
            lblTitle.Text = this.Text = "Add New Doctor";
            gbDoctorData.Values.Description = "ID : ???";
        }

        private async void ShowEditScreen()
        {
            _Mode = enMode.Edit;

            lblTitle.Text = this.Text = "Edit Doctor";

            if (_DoctorData != null)
            {
                ctrlPersonDetailsSelector1.DisableFilter();
                gbDoctorData.Values.Description = $"ID : {_DoctorData.ID}";
                cbDepartments.SelectedValue = _DoctorData.DepartmentID;
                cbSpecializations.SelectedValue = _DoctorData.SpecializationID;
                ckActive.Checked = _DoctorData.IsActive.Value;

                if (ctrlPersonDetailsSelector1.PersonData == null)
                    await ctrlPersonDetailsSelector1.LoadPersonData(_DoctorData.PersonID);

                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
                MessageBox.Show("No Doctor selected for editing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadDepartments()
        {
            cbDepartments.DataSource = await clsDepartment.GetAll();
            cbDepartments.DisplayMember = "Name";
            cbDepartments.ValueMember = "ID";
        }

        private async Task LoadSpecializations()
        {
            cbSpecializations.DataSource = await clsSpecialization.GetAll();
            cbSpecializations.DisplayMember = "Name";
            cbSpecializations.ValueMember = "ID";
        }

        private async void frmAddNewEditDoctor_Load(object sender, EventArgs e)
        {
            ctrlPersonDetailsSelector1.OnPersonSelected += PersonSelected;

            await LoadDepartments();
            await LoadSpecializations();

            if (ID.HasValue)
                _DoctorData = await clsDoctor.Find(ID);

            if (_Mode == enMode.AddNew)
                ShowAddNewScreen();
            else
            {
                if (_DoctorData != null)
                    ShowEditScreen();
                else
                    DisableScreen();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ctrlPersonDetailsSelector1.PersonData != null)
            {
                _DoctorData.Person = ctrlPersonDetailsSelector1.PersonData;

                if (_Mode == enMode.AddNew)
                {
                    _DoctorData.PersonID = ctrlPersonDetailsSelector1.PersonData.ID;
                    _DoctorData.CreatedByUserID = clsGlobal.CurrentUser.ID;
                    _DoctorData.CreatedByUsername = clsGlobal.CurrentUser.Username;
                }

                _DoctorData.DepartmentID = Convert.ToByte(cbDepartments.SelectedValue);
                _DoctorData.SpecializationID = Convert.ToByte(cbSpecializations.SelectedValue);
                _DoctorData.IsActive = ckActive.Checked;

                if (await _DoctorData.Save())
                {
                    ShowEditScreen();
                    OnDoctorDataSaved?.Invoke(_DoctorData);
                    MessageBox.Show("Doctor data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Failed to save Doctor data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please select a person before saving.", "No Person Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _DoctorData.Person = ctrlPersonDetailsSelector1.PersonData;
            OnDoctorDataSaved?.Invoke(_DoctorData);
            this.Close();
        }
    }
}
