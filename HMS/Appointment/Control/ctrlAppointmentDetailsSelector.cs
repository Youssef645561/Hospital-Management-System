using HMS.BLL;
using HMS.People;
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

namespace HMS.Appointment.Control
{
    public partial class ctrlAppointmentDetailsSelector : UserControl
    {
        public event Action<clsAppointment> OnAppointmentSelected;

        public clsAppointment AppointmentData { get { return ctrlAppointmentDetails1.AppointmentData; } }

        public ctrlAppointmentDetailsSelector()
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
                await ctrlAppointmentDetails1.LoadAppointmentData(Convert.ToInt32(tbFilter.Text));

                if (AppointmentData == null)
                    MessageBox.Show($"No Appointment found with ID {tbFilter.Text}.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    OnAppointmentSelected?.Invoke(AppointmentData);
            }
            else
            {
                MessageBox.Show("Please enter a valid ID to search.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddNewEditAppointment frm = new frmAddNewEditAppointment();
            frm.OnAppointmentDataSaved +=
            ((Appointment) =>
            {
                tbFilter.Text = Appointment.ID.ToString();
                ctrlAppointmentDetails1.LoadAppointmentData(Appointment);
                OnAppointmentSelected?.Invoke(Appointment);
            });
            frm.ShowDialog();
        }

        public async Task LoadAppointmentData(int? AppointmentID)
        {
            if (AppointmentID.HasValue)
            {
                await ctrlAppointmentDetails1.LoadAppointmentData(AppointmentID.Value);
                DisableFilter();
            }
        }
    }
}
