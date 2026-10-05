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

namespace HMS.Patient_Charge.Control
{
    public partial class ctrlPatientChargeDetailsSelector : UserControl
    {
        public event Action<clsPatientCharge> OnPatientChargeSelected;

        public clsPatientCharge PatientChargeData { get { return ctrlPatientChargeDetails1.PatientChargeData; } }

        public ctrlPatientChargeDetailsSelector()
        {
            InitializeComponent();
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
                await ctrlPatientChargeDetails1.LoadPatientChargeData(Convert.ToInt32(tbFilter.Text));

                if (PatientChargeData == null)
                    MessageBox.Show($"No Patient Charge found with ID {tbFilter.Text}.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    OnPatientChargeSelected?.Invoke(PatientChargeData);
            }
            else
            {
                MessageBox.Show("Please enter a valid ID to search.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddNewEditPatientCharge frm = new frmAddNewEditPatientCharge();
            frm.OnPatientChargeDataSaved +=
            ((PatientCharge) =>
            {
                tbFilter.Text = PatientCharge.ID.ToString();
                ctrlPatientChargeDetails1.LoadPatientChargeData(PatientCharge);
                OnPatientChargeSelected?.Invoke(PatientCharge);
            });
            frm.ShowDialog();
        }

        public async Task LoadPatientChargeData(int? PatientChargeID)
        {
            if (PatientChargeID.HasValue)
            {
                await ctrlPatientChargeDetails1.LoadPatientChargeData(PatientChargeID.Value);
                DisableFilter();

                if (PatientChargeData == null)
                    MessageBox.Show($"No Patient Charge found with ID {tbFilter.Text}.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    OnPatientChargeSelected?.Invoke(PatientChargeData);
            }
        }
    }
}
