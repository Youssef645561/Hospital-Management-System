using HMS.BLL;
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

namespace HMS.Users
{
    public partial class frmAddNewEditUser : JOSubForm
    {
        public event Action<clsUser> OnUserDataSaved;

        public enum enMode { AddNew, Edit }
        private enMode _Mode;
        public enMode Mode { get { return _Mode; } }

        private bool IsValid = false;
        private int ID { get; set; }
        private clsUser _UserData { get; set; } = null;
        public clsUser UserData { get { return _UserData; } }

        public frmAddNewEditUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddNewEditUser(int ID)
        {
            InitializeComponent();
            _Mode = enMode.Edit;
            this.ID = ID;
        }
        public frmAddNewEditUser(clsUser UserData)
        {
            InitializeComponent();
            _Mode = enMode.Edit;
            this._UserData = UserData;
        }

        private void ShowAddNewScreen()
        {
            _UserData = new clsUser();
            this.Text = lblTitle.Text = "Add New User";
            gbUserData.Values.Description = "ID : ???";
            lblResetPassword.Visible = false;
            tbPassword.Visible = true;
            ckActive.Checked = true;
            ckActive.Enabled = cbUserRoles.Enabled = true;
        }

        private void ShowEditScreen()
        {
            _Mode = enMode.Edit;

            this.Text = lblTitle.Text = "Edit User";
            lblResetPassword.Visible = true;
            tbPassword.Visible = false;

            if (_UserData != null)
            {
                gbUserData.Values.Description = $"ID : {_UserData.ID}";
                tbUsername.Text = _UserData.Username;
                cbUserRoles.SelectedValue = _UserData.UserRoleID;
                ckActive.Checked = _UserData.IsActive.Value;
                btnSave.Enabled = true;

                ckActive.Enabled = cbUserRoles.Enabled = (_UserData.ID != clsGlobal.CurrentUser.ID);
            }
            else
            {
                lblResetPassword.Enabled = btnSave.Enabled = false;
                MessageBox.Show("Failed to load user data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task LoadUserRoles()
        {
            cbUserRoles.DataSource = await clsUserRole.GetAll(false);
            cbUserRoles.DisplayMember = "Name";
            cbUserRoles.ValueMember = "ID";
        }

        private async void frmAddNewEditUser_Load(object sender, EventArgs e)
        {
            await LoadUserRoles();

            if (_Mode == enMode.AddNew)
                ShowAddNewScreen();
            else
            {
                if (_UserData == null)
                    _UserData = await clsUser.Find(ID);
                ShowEditScreen();
            }
        }

        private void lblTitle_SizeChanged(object sender, EventArgs e)
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            IsValid = true;
            await ValidateAll();

            if (IsValid)
            {
                _UserData.Username = tbUsername.Text;
                _UserData.UserRoleID = Convert.ToByte(cbUserRoles.SelectedValue);
                _UserData.Password = _Mode == enMode.AddNew ? tbPassword.Text : null;
                _UserData.IsActive = ckActive.Checked;

                if (await _UserData.Save())
                {
                    ShowEditScreen();
                    OnUserDataSaved?.Invoke(_UserData);
                    MessageBox.Show("User data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to save user data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("There are errors in the entered data. Please correct them and try again.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private async Task ValidateAll()
        {
            await CheckUsername();
            this.ValidateChildren();
        }

        private async void tbUsername_TextChanged(object sender, EventArgs e)
        {
            await CheckUsername();
        }

        private async Task CheckUsername()
        {
            if (tbUsername.Text == _UserData?.Username)
            {
                errp1.SetError(tbUsername, "");
                return;
            }

            if (string.IsNullOrEmpty(tbUsername.Text))
            {
                errp1.SetError(tbUsername, "This field is required");
                IsValid = false;
            }
            else if (await clsUser.IsUsernameExist(tbUsername.Text))
            {
                errp1.SetError(tbUsername, $"User with {tbUsername.Text} username is exist");
                IsValid = false;
            }
            else
                errp1.SetError(tbUsername, "");
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                if (string.IsNullOrEmpty(tbPassword.Text))
                {
                    errp1.SetError(tbPassword, "This field is required");
                    IsValid = false;
                }
                else
                    errp1.SetError(tbPassword, "");
            }
        }

        private void lblResetPassword_LinkClicked(object sender, EventArgs e)
        {
            (new frmChangeUserPassword(_UserData)).ShowDialog();
        }
    }
}
