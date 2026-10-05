using Common;
using HMS.BLL;
using HMS.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Users.Controls
{
    public partial class ctrlUserDetails : UserControl
    {
        private clsUser _UserData { get; set; }
        public clsUser UserData { get { return _UserData; } }

        public ctrlUserDetails()
        {
            InitializeComponent();
        }

        private void LoadEmptyScreen()
        {
            lblID.Text = "???";
            lblUsername.Text = "???";
            lblActive.Text = "???";
            lblRole.Text = "???";
            lblCreatedDate.Text = "???";
            lblEdit.Enabled = false;
        }

        private void LoadDataScreen()
        {
            lblID.Text = _UserData.ID.ToString();
            lblUsername.Text = _UserData.Username;
            lblRole.Text = _UserData.UserRole.Name.ToString();
            lblCreatedDate.Text = clsUtility.DateTimeFormat(_UserData.CreatedDate);
            lblEdit.Enabled = true;

            if (_UserData.IsActive.Value)
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

        public async Task LoadUserData(int userid)
        {
            if (userid > 0)
            {
                _UserData = await clsUser.Find(userid);

                if (_UserData != null)
                    LoadDataScreen();
                else
                    LoadEmptyScreen();
            }
            else
            {
                _UserData = null;
                LoadEmptyScreen();
            }
        }

        public void LoadUserData(clsUser User)
        {
            if (User != null)
            {
                _UserData = User;
                LoadDataScreen();
            }
            else
            {
                _UserData = null;
                LoadEmptyScreen();
            }
        }

        private void lblEdit_LinkClicked(object sender, EventArgs e)
        {
            if (_UserData != null && _UserData.ID.HasValue)
            {
                frmAddNewEditUser frm = new frmAddNewEditUser(_UserData);
                frm.OnUserDataSaved += LoadUserData;
                frm.ShowDialog();
            }
        }
    }
}
