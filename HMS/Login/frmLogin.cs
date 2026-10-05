using Common;
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

namespace HMS.Login
{
    public partial class frmLogin : JOSubForm
    {
        bool IsValid = false;

        frmMain frm = new frmMain();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void tb_Validating(object sender, CancelEventArgs e)
        {
            Control control = (Control)sender;

            if (control != null)
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    errp1.SetError(control, "This field is required.");
                    IsValid = false;
                }
                else
                    errp1.SetError(control, string.Empty);
            }
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;

            e.Handled = true;

            Control current = (Control)sender;

            SelectNextControl(current, true, true, true, false);
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            IsValid = true;

            this.ValidateChildren();

            if (IsValid)
            {
                clsUser user = await clsUser.Authenticate(tbUsername.Text, tbPassword.Text);
                if (user != null)
                {
                    if (user.IsActive.Value)
                    {
                        if (ckRememberMe.Checked)
                            clsUtility.SetCredentials(tbUsername.Text, tbPassword.Text);
                        else
                            clsUtility.SetCredentials("", "");

                        clsGlobal.CurrentUser = user;

                        this.Visible = false;
                        frm.ShowDialog();
                        this.Visible = true;
                    }
                    else
                        MessageBox.Show("Your account is inactive. Please contact the administrator.", "Account Inactive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please correct the errors before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string username = string.Empty, password = string.Empty;

            clsUtility.GetCredentials(ref username, ref password);
            tbUsername.Text = username;
            tbPassword.Text = password;
        }
    }
}
