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
    public partial class frmChangeUserPassword : JOSubForm
    {
        int? ID { get; set; } = null;
        clsUser UserData { get; set; } = null;

        public frmChangeUserPassword(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        public frmChangeUserPassword(clsUser UserData)
        {
            InitializeComponent();
            this.UserData = UserData;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (await clsUser.IsPasswordCorrect(UserData?.ID, tbCurrentPassword.Text))
            {
                if (tbNewPassword.Text == tbConfirmPassword.Text)
                {
                    if (!string.IsNullOrEmpty(tbNewPassword.Text))
                    {
                        if (await clsUser.ChangePassword(UserData.ID, tbNewPassword.Text))
                        {
                            MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnClose.PerformClick();
                        }
                        else
                            MessageBox.Show("Failed to change password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Please enter a new password.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("The new password and confirmation password do not match. Please correct them and try again.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("The current password is incorrect. Please enter the correct password and try again.", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmChangeUserPassword_Load(object sender, EventArgs e)
        {
            if (ID.HasValue && ID.Value > 0)
                UserData = await clsUser.Find(ID);

            if (UserData == null)
            {
                gbChangePassword.Values.Heading = "???";
                gbChangePassword.Values.Description = $"ID : ???";
                btnSave.Enabled = false;
                MessageBox.Show("User data could not be found. The operation cannot continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                gbChangePassword.Values.Heading = UserData.Username;
                gbChangePassword.Values.Description = $"ID : {UserData.ID}";
            }
        }
    }
}
