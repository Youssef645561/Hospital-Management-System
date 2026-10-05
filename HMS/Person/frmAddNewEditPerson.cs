using Common;
using HMS.BLL;
using HMS.People.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Youssef.WinForms.Controls;

namespace HMS.People
{
    public partial class frmAddNewEditPerson : JOSubForm
    {
        public enum enMode { AddNew, Edit }
        enMode _Mode;

        int? ID = null;
        bool IsValid = false;

        clsPerson personData = null;

        public event Action<clsPerson> OnPersonDataSaved;

        public frmAddNewEditPerson()
        {
            InitializeComponent();
            ShowAddNewScreen();
        }

        public frmAddNewEditPerson(int? ID)
        {
            InitializeComponent();

            this.ID = ID;
        }

        public frmAddNewEditPerson(clsPerson person)
        {
            InitializeComponent();
            this.ID = null;
            EditPerson(person);
        }

        private void lblTitle_SizeChanged(object sender, EventArgs e)
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
        }

        private async void frmAddNewEditPerson_Load(object sender, EventArgs e)
        {
            ofdPersonalImage.FileName = string.Empty;
            dtpDateOfBirth.MaxDate = DateTime.Now;

            if (ID.HasValue)
                await EditPerson(ID);

            lblTitle.Text = this.Text = _Mode == enMode.AddNew ? "Add New Person" : "Edit Person";
        }

        private void DisableScreen()
        {
            this.personData = null;
            gbPersonData.Enabled = btnSave.Enabled = false;
            MessageBox.Show("Person data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowAddNewScreen()
        {
            _Mode = enMode.AddNew;

            personData = new clsPerson();
            gbPersonData.Values.Description = "ID : ???";
            ofdPersonalImage.FileName = null;
            rbMale.Checked = true;
            pbpPersonalImage.Image = Properties.Resources.Male_512;
        }

        private void ShowEditScreen()
        {
            _Mode = enMode.Edit;

            gbPersonData.Values.Description = $"ID : {personData.ID}";
            tbFirstName.Text = personData.FirstName;
            tbSecondName.Text = personData.SecondName;
            tbLastName.Text = personData.LastName;
            dtpDateOfBirth.Value = personData.DateOfBirth.Value;
            tbEmail.Text = personData.Email;
            tbPhone.Text = personData.Phone;

            if (personData.PersonalImage != null)
            {
                Bitmap image = clsUtility.ConvertBytesToImage(personData.PersonalImage);

                if (image != null)
                {
                    pbpPersonalImage.Image = image;
                    pbpPersonalImage.Tag = "Filled";
                    lblRemove.Visible = true;
                }
                else
                    pbpPersonalImage.Tag = string.Empty;
            }
            else
                pbpPersonalImage.Tag = string.Empty;


            if (personData.Gender == clsPerson.enGender.Male)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;
        }

        private async Task EditPerson(int? ID)
        {
            if (ID.HasValue && ID > 0)
            {
                personData = await clsPerson.Find(ID);

                if (personData == null)
                    DisableScreen();
                else
                    ShowEditScreen();
            }
            else
                DisableScreen();
        }

        private void EditPerson(clsPerson persondata)
        {
            if (persondata == null)
                DisableScreen();
            else
            {
                _Mode = enMode.Edit;
                this.personData = persondata;
                ShowEditScreen();
            }
        }

        private void lblSetImage_LinkClicked(object sender, EventArgs e)
        {
            if (ofdPersonalImage.ShowDialog() == DialogResult.OK)
            {
                lblRemove.Visible = true;

                pbpPersonalImage.ImageLocation = ofdPersonalImage.FileName;
                pbpPersonalImage.Tag = "Filled";
            }
        }

        private void lblRemove_LinkClicked(object sender, EventArgs e)
        {
            pbpPersonalImage.Image = null;
            pbpPersonalImage.Tag = string.Empty;
            ofdPersonalImage.FileName = null;
            lblRemove.Visible = false;
            HandleImage();
        }

        private void HandleImage()
        {
            if (rbMale.Checked)
                pbpPersonalImage.Image = Properties.Resources.Male_512;
            else
                pbpPersonalImage.Image = Properties.Resources.Female_512;
        }

        private void rbGender_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pbpPersonalImage.Tag.ToString()))
                HandleImage();
            else
                lblRemove.Visible = true;
        }

        private byte[] HandleImageBytes()
        {
            if (_Mode == enMode.AddNew)
            {
                if (string.IsNullOrEmpty(ofdPersonalImage.FileName))
                    return null;
                else
                    return clsUtility.ReadBytesFromFile(ofdPersonalImage.FileName);
            }
            else
            {
                if (string.IsNullOrEmpty(pbpPersonalImage.Tag.ToString()))
                    return null;
                else
                {
                    if (string.IsNullOrEmpty(ofdPersonalImage.FileName))
                        return personData.PersonalImage;
                    else
                        return clsUtility.ReadBytesFromFile(ofdPersonalImage.FileName);
                }
            }
        }

        private void ValidateAll()
        {
            this.ValidateChildren();
            ValidateEmail();
        }

        private void ValidateEmail()
        {
            if (string.IsNullOrEmpty(tbEmail.Text))
                errp1.SetError(tbEmail, "");
            else
            {
                if (clsUtility.IsEmail(tbEmail.Text))
                    errp1.SetError(tbEmail, "");
                else
                {
                    errp1.SetError(tbEmail, "Invalid Email");
                    IsValid = false;
                }
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            ValidateEmail();
        }

        private void tb_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.Control control = (System.Windows.Forms.Control)sender;

            if (string.IsNullOrEmpty(control.Text))
            {
                errp1.SetError(control, "This field is required");
                IsValid = false;
            }
            else
                errp1.SetError(control, "");
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            e.SuppressKeyPress = true;

            System.Windows.Forms.Control current = (System.Windows.Forms.Control)sender;

            SelectNextControl(current, true, true, true, true);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            IsValid = true;
            ValidateAll();

            if (IsValid)
            {
                if(_Mode == enMode.AddNew)
                {
                    personData.CreatedByUserID = clsGlobal.CurrentUser.ID;
                    personData.CreatedByUsername = clsGlobal.CurrentUser.Username;
                }

                personData.FirstName = tbFirstName.Text;
                personData.SecondName = string.IsNullOrEmpty(tbSecondName.Text) ? null : tbSecondName.Text;
                personData.LastName = tbLastName.Text;
                personData.DateOfBirth = dtpDateOfBirth.Value;
                personData.Email = string.IsNullOrEmpty(tbEmail.Text) ? null : tbEmail.Text;
                personData.Gender = rbMale.Checked ? clsPerson.enGender.Male : clsPerson.enGender.Female;
                personData.Phone = tbPhone.Text;
                personData.PersonalImage = HandleImageBytes();

                if (await personData.Save())
                {
                    ShowEditScreen();
                    OnPersonDataSaved?.Invoke(personData);
                    MessageBox.Show("Person data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Failed to save person data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Invalid data. Please make sure all fields are filled correctly.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
