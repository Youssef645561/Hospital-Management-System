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

namespace HMS.User_Roles
{
    public partial class frmAddNewEditUserRole : JOSubForm
    {
        private enum enMode { AddNew, Edit }
        private enMode _Mode;

        private byte? ID { get; set; } = null;
        private clsUserRole UserRole { get; set; } = null;

        public frmAddNewEditUserRole()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddNewEditUserRole(byte? ID)
        {
            InitializeComponent();
            _Mode = enMode.Edit;
            this.ID = ID;
        }

        private void ShowAddNewScreen()
        {
            lblTitle.Text = "Add New User Role";
            gbUserRoleData.Values.Description = "ID : ???";
            lblPermissions.Text = "???";
        }

        private void ShowEditScreen()
        {
            lblTitle.Text = "Edit User Role";
            gbUserRoleData.Values.Description = $"ID : {UserRole.ID}";
            tbName.Text = UserRole.Name;
            lblPermissions.Text = UserRole.Permissions.ToString();
        }

        private async void frmAddNewEditUserRole_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                UserRole = new clsUserRole();
                ShowAddNewScreen();
            }
            else
            {
                UserRole = await clsUserRole.Find(ID);
                ShowEditScreen();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Please enter a role name.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbName.Text != UserRole?.Name)
            {
                if (await clsUserRole.IsExist(tbName.Text))
                {
                    MessageBox.Show("This role name already exists. Please enter a different name.", "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                UserRole.Name = tbName.Text;
            }

            if (await UserRole.Save())
            {
                _Mode = enMode.Edit;
                ShowEditScreen();
                MessageBox.Show("User role saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Failed to save user role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lblTitle_SizeChanged(object sender, EventArgs e)
        {
            lblTitle.Left = (this.Width - lblTitle.Width) / 2;
        }
    }
}
