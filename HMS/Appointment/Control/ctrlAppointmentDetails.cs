using Common;
using HMS.BLL;
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

namespace HMS.Appointment
{
    public partial class ctrlAppointmentDetails : UserControl
    {
        public ctrlAppointmentDetails()
        {
            InitializeComponent();
        }

        private clsAppointment _AppointmentData;
        public clsAppointment AppointmentData { get { return _AppointmentData; } }

        private async void LoadEmptyScreen()
        {
            lblReschedule.Enabled = false;
            lblID.Text = "???";
            lblStatus.Text = "???";
            lblStatus.StateCommon.ShortText.Color1 = Color.Black;
            lblType.Text = "???";
            lblDay.Text = "???";
            lblDate.Text = "???";
            lblTime.Text = "???";
            lblDoctorName.Text = "???";
            lblCreatedDate.Text = "???";
            lblCreatedBy.Text = "???";
            ctrlPatientDetails1.LoadPatientData(-1);
        }

        private Color HandleStatusColor()
        {
            switch (_AppointmentData.Status)
            {
                case clsAppointment.enStatus.Scheduled:
                    return Color.DodgerBlue;
                case clsAppointment.enStatus.Waiting:
                    return Color.DarkOrange;
                case clsAppointment.enStatus.Completed:
                    return Color.ForestGreen;
                case clsAppointment.enStatus.Cancelled:
                    return Color.Red;
                case clsAppointment.enStatus.NoShow:
                    return Color.DimGray;
                default:
                    return Color.DimGray;
            }
        }

        private async void LoadDataScreen()
        {
            lblID.Text = _AppointmentData.ID.ToString();
            lblStatus.Text = _AppointmentData.Status == clsAppointment.enStatus.NoShow ? "No Show" : _AppointmentData.Status.ToString();
            lblType.Text = _AppointmentData.Type.ToString();
            lblDay.Text = _AppointmentData.DoctorSchedule.DayOfWeek.ToString();
            lblDoctorName.Text = _AppointmentData.DoctorName;
            lblDate.Text = clsUtility.DateFormat(_AppointmentData.Date);
            lblTime.Text = clsUtility.TimeFormat(_AppointmentData.Date) + " to " + clsUtility.TimeFormat(_AppointmentData.Date.Value.AddMinutes((double)_AppointmentData.DoctorSchedule.Period.SlotDuration));
            lblCreatedDate.Text = clsUtility.DateTimeFormat(_AppointmentData.CreatedDate);
            lblCreatedBy.Text = _AppointmentData.CreatedByUsername;

            lblStatus.StateCommon.ShortText.Color1 = HandleStatusColor();

            lblReschedule.Enabled = ((_AppointmentData.Status == clsAppointment.enStatus.NoShow) || (_AppointmentData.Status == clsAppointment.enStatus.Scheduled));

            await ctrlPatientDetails1.LoadPatientData(_AppointmentData.PatientID.Value);
        }

        public async Task LoadAppointmentData(int Appointmentid)
        {
            if (Appointmentid > 0)
            {
                _AppointmentData = await clsAppointment.Find(Appointmentid);

                if (_AppointmentData != null)
                    LoadDataScreen();
                else
                    LoadEmptyScreen();
            }
            else
            {
                _AppointmentData = null;
                LoadEmptyScreen();
            }
        }
        public async void LoadAppointmentData(clsAppointment Appointment)
        {
            if (Appointment != null)
            {
                _AppointmentData = Appointment;
                LoadDataScreen();
            }
            else
            {
                _AppointmentData = null;
                LoadEmptyScreen();
            }
        }

        private void lblReschedule_LinkClicked(object sender, EventArgs e)
        {
            frmAddNewEditAppointment frm = new frmAddNewEditAppointment(_AppointmentData.ID);
            frm.ShowDialog();
        }
    }
}
