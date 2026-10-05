using Common;
using HMS.BLL;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.People.Control
{
    public partial class ctrlPersonDetails : UserControl
    {
        private clsPerson _PersonData;
        public clsPerson PersonData { get { return _PersonData; } }

        public ctrlPersonDetails()
        {
            InitializeComponent();
        }

        public void DisablePersonEdit()
        {
            lblEdit.Visible = false;
        }

        private void LoadEmptyScreen()
        {
            lblID.Text = "???";
            lblName.Text = "???";
            lblDateOfBirth.Text = "???";
            lblGender.Text = "???";
            lblEmail.Text = "???";
            lblPhone.Text = "???";
            lblCreatedDate.Text = "???";
            lblCreatedBy.Text = "???";
            pbpPersonalImage.Image = Properties.Resources.Male_512;
            lblEdit.Enabled = false;
        }

        private void LoadDataScreen()
        {
            lblID.Text = _PersonData.ID?.ToString() ?? "???";
            lblName.Text = _PersonData.FullName ?? "???";
            lblDateOfBirth.Text = clsUtility.DateFormat(_PersonData.DateOfBirth) ?? "???";
            lblGender.Text = _PersonData.Gender.HasValue ? (_PersonData.Gender.Value.ToString()) : "???";
            lblEmail.Text = _PersonData.Email ?? "No Email";
            lblPhone.Text = _PersonData.Phone ?? "No Phone";
            lblCreatedDate.Text = clsUtility.DateTimeFormat(_PersonData.CreatedDate) ?? "???";
            lblCreatedBy.Text = _PersonData.CreatedByUsername ?? "Unknown";

            if (_PersonData.PersonalImage != null)
            {
                using (MemoryStream ms = new MemoryStream(_PersonData.PersonalImage))
                using (Image image = Image.FromStream(ms))
                {
                    pbpPersonalImage.Image = new Bitmap(image);
                    pbpPersonalImage.Tag = "Filled";
                }
            }
            else
                pbpPersonalImage.Image = _PersonData.Gender == clsPerson.enGender.Male ? Properties.Resources.Male_512 : Properties.Resources.Female_512;

            lblEdit.Enabled = true;
        }

        public async Task LoadPersonData(int personid)
        {
            if (personid > 0)
            {
                _PersonData = await clsPerson.Find(personid);

                if (_PersonData != null)
                    LoadDataScreen();
                else
                    LoadEmptyScreen();
            }
            else
            {
                _PersonData = null;
                LoadEmptyScreen();
            }
        }

        public void LoadPersonData(clsPerson person)
        {
            if (person != null)
            {
                _PersonData = person;
                LoadDataScreen();
            }
            else
            {
                _PersonData = null;
                LoadEmptyScreen();
            }
        }

        private void lblEdit_LinkClicked(object sender, EventArgs e)
        {
            if (_PersonData != null && _PersonData.ID.HasValue)
            {
                frmAddNewEditPerson frm = new frmAddNewEditPerson(_PersonData);
                frm.OnPersonDataSaved += LoadPersonData;
                frm.ShowDialog();
            }
        }
    }
}
