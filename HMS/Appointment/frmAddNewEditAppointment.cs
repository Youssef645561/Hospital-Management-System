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
using Youssef.WinForms.Controls;
using static HMS.BLL.clsPeriod;
using static System.Net.Mime.MediaTypeNames;

namespace HMS.Appointment
{
    public partial class frmAddNewEditAppointment : JOSubForm
    {
        (int? DoctorScheduleID, List<clsPeriod.clsTimeSlot> TimeSlots)? TimeSlotsData;
        bool IsSpecializationsLoading = false, IsDoctorsLoading = false;

        public enum enMode { Schedule, Reschedule }
        enMode _Mode;

        int? ID = null, DoctorScheduleID = null;

        clsAppointment _AppointmentData = null;

        public event Action<clsAppointment> OnAppointmentDataSaved;

        public frmAddNewEditAppointment()
        {
            InitializeComponent();
            _Mode = enMode.Schedule;
        }
        public frmAddNewEditAppointment(int? ID)
        {
            InitializeComponent();
            _Mode = enMode.Reschedule;
            this.ID = ID;
        }

        public async void LoadPatient(int? PatientID)
        {
            await ctrlPatientDetailsSelector1.LoadPatientData(PatientID);
        }

        private void lblTitle_SizeChanged(object sender, EventArgs e)
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
        }

        private void DisableScreen()
        {
            this._AppointmentData = null;
            gbAppointmentData.Enabled = btnSave.Enabled = false;
            MessageBox.Show("Appointment data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowAddNewScreen()
        {
            _Mode = enMode.Schedule;
            _AppointmentData = new clsAppointment();
            lblTitle.Text = this.Text = "Schedule New Appointment";

            gbAppointmentData.Values.Description = string.Empty;
        }

        private async void ShowEditScreen()
        {
            _Mode = enMode.Reschedule;
            lblTitle.Text = this.Text = "Reschedule Appointment";
            gbAppointmentData.Values.Description = $"ID = {_AppointmentData.ID}";

            if (ctrlPatientDetailsSelector1.PatientData == null)
                await ctrlPatientDetailsSelector1.LoadPatientData(_AppointmentData.PatientID);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrlPatientDetailsSelector1.PatientData != null)
                tcAddNewEditAppointment.SelectedTab = tpAppointmentData;
            else
                MessageBox.Show("Please select a patient first.", "Patient Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ctrlPatientDetailsSelector1.PatientData == null)
            {
                MessageBox.Show("Please select a patient first.", "Patient Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbSpecializations.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a specialization.", "Specialization Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbDoctors.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a doctor.", "Doctor Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!cbTimeSlots.Visible)
            {
                MessageBox.Show("No available time slots for the selected date. Please select another date.", "No Available Slots", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbTimeSlots.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an available time slot.", "Time Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _AppointmentData.PatientID = ctrlPatientDetailsSelector1.PatientData.ID;
            _AppointmentData.CreatedByUserID = clsGlobal.CurrentUser.ID;
            _AppointmentData.CreatedByUsername = clsGlobal.CurrentUser.Username;

            _AppointmentData.Date = dtpDate.Value.Date.Add((TimeSpan)cbTimeSlots.SelectedValue); _AppointmentData.Type = rbExamination.Checked ? clsAppointment.enType.Examination : clsAppointment.enType.Consultation;
            _AppointmentData.DoctorScheduleID = DoctorScheduleID;
            _AppointmentData.DoctorSpecializationID = Convert.ToByte(cbSpecializations.SelectedValue);

            if (_Mode == enMode.Schedule)
            {
                if (await _AppointmentData.Schedule())
                {
                    ShowEditScreen();

                    OnAppointmentDataSaved?.Invoke(_AppointmentData);

                    MessageBox.Show("Appointment scheduled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                    MessageBox.Show("Failed to schedule Appointment . Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (await _AppointmentData.Reschedule())
                {
                    OnAppointmentDataSaved?.Invoke(_AppointmentData);

                    MessageBox.Show("Appointment rescheduled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                    MessageBox.Show("Failed to reschedule Appointment . Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcAddNewEditAppointment.SelectedTab = tpPatientData;
        }

        private async Task LoadSpecializations()
        {
            IsSpecializationsLoading = true;

            cbSpecializations.DataSource = await clsSpecialization.GetAll();
            cbSpecializations.DisplayMember = "Name";
            cbSpecializations.ValueMember = "ID";

            IsSpecializationsLoading = false;
        }

        private void LoadDoctors()
        {
            IsDoctorsLoading = true;
            cbDoctors.DataSource = clsDoctor.GetAll(Convert.ToByte(cbSpecializations.SelectedValue));

            if (cbDoctors.Items?.Count > 0)
            {
                cbDoctors.DisplayMember = "Name";
                cbDoctors.ValueMember = "ID";
            }
            IsDoctorsLoading = false;
        }

        private async Task LoadTimeSlots()
        {
            if (cbDoctors.Items?.Count > 0)
            {
                TimeSlotsData = await clsPeriod.GetSlotsList(Convert.ToInt32(cbDoctors.SelectedValue), dtpDate.Value.ToString("dddd"));

                if (TimeSlotsData != null)
                {
                    DoctorScheduleID = TimeSlotsData.Value.DoctorScheduleID;

                    cbTimeSlots.DataSource = TimeSlotsData.Value.TimeSlots;
                    cbTimeSlots.DisplayMember = "Text";
                    cbTimeSlots.ValueMember = "Value";
                }
                else
                    cbTimeSlots.DataSource = DoctorScheduleID = null;
            }
        }

        private async void frmAddNewEditAppointment_Load(object sender, EventArgs e)
        {
            dtpDate.CustomFormat = "dddd dd/MM/yyyy";

            dtpDate.MinDate = DateTime.Now;

            tcAddNewEditAppointment.Appearance = TabAppearance.FlatButtons;
            tcAddNewEditAppointment.ItemSize = new Size(0, 1);
            tcAddNewEditAppointment.SizeMode = TabSizeMode.Fixed;

            await LoadSpecializations();

            if (ID.HasValue)
                _AppointmentData = await clsAppointment.Find(ID);

            if (_Mode == enMode.Schedule)
                ShowAddNewScreen();
            else
            {
                if (_AppointmentData != null)
                    ShowEditScreen();
                else
                    DisableScreen();
            }
        }

        private void cbSpecializations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsSpecializationsLoading)
            {
                LoadDoctors();
                if (cbDoctors.Items?.Count > 0)
                {
                    cbDoctors.Enabled = true;
                    return;
                }
                cbTimeSlots.DataSource = DoctorScheduleID = null;
                cbDoctors.Enabled = dtpDate.Enabled = false;
                cbTimeSlots.Visible = false;
                lblTime.Visible = true;
            }
        }

        private async void cbDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsDoctorsLoading)
            {
                dtpDate.Enabled = true;

                cbTimeSlots.DataSource = DoctorScheduleID = null;
                cbTimeSlots.Visible = false;
                lblTime.Visible = true;
            }
        }

        private async void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            await LoadTimeSlots();

            if (cbTimeSlots.Items?.Count > 0)
            {
                cbTimeSlots.Visible = true;
                lblTime.Visible = false;
            }
            else
            {
                cbTimeSlots.Visible = false;
                lblTime.Visible = true;
            }
        }
    }
}