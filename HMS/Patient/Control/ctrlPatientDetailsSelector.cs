using HMS.BLL;
using HMS.Patients;
using HMS.Patients.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Patient.Control
{
    public partial class ctrlPatientDetailsSelector : UserControl
    {
        public event Action<clsPatient> OnPatientSelected;

        public clsPatient PatientData { get { return ctrlPatientDetails1.PatientData; } }

        public ctrlPatientDetailsSelector()
        {
            InitializeComponent();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFilter.Text)
            {
                case "ID":
                    tbFilter.AllowLetters = tbFilter.AllowSpecialCharacters = false;
                    tbFilter.AllowDigits = true;
                    break;
                case "Medical Record No":
                    tbFilter.AllowSpecialCharacters = false;
                    tbFilter.AllowLetters = tbFilter.AllowDigits = true;
                    break;
            }
            tbFilter.Focus();
            tbFilter.Text = string.Empty;
        }

        public void DisableFilter()
        {
            this.gbFilter.Visible = false;
        }

        public void EnableFilter()
        {
            this.gbFilter.Visible = true;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbFilter.Text))
            {
                if (cbFilter.Text == "ID")
                    await ctrlPatientDetails1.LoadPatientData(Convert.ToInt32(tbFilter.Text));
                else
                    await ctrlPatientDetails1.LoadPatientData(tbFilter.Text);

                if (PatientData == null)
                    MessageBox.Show($"No Patient found with {cbFilter.Text} {tbFilter.Text}.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    OnPatientSelected?.Invoke(PatientData);
            }
            else
            {
                MessageBox.Show($"Please enter a valid {cbFilter.Text} to search.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddNewEditPatient frm = new frmAddNewEditPatient();
            frm.OnPatientDataSaved +=
            ((Patient) =>
            {
                tbFilter.Text = Patient.ID.ToString();
                ctrlPatientDetails1.LoadPatientData(Patient);
                OnPatientSelected?.Invoke(Patient);
            });
            frm.ShowDialog();
        }

        public async Task LoadPatientData(int? PatientID)
        {
            if (PatientID.HasValue)
            {
                await ctrlPatientDetails1.LoadPatientData(PatientID.Value);
                DisableFilter();
            }
        }
    }
}
