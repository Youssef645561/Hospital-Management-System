using Common;
using HMS.BLL;
using HMS.Doctors;
using HMS.Patient_Charge;
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
    public partial class ctrlPatientAppointmentsHistory : UserControl
    {
        public ctrlPatientAppointmentsHistory()
        {
            InitializeComponent();
        }

        private int? _PatientID;
        public int? PatientID { get { return _PatientID; } }

        private DataTable _dtPatientAppointments = null;
        public DataTable dtPatientAppointments { get { return _dtPatientAppointments; } }

        string StatusCellValue;

        private async Task LoadPatientAppointmentsData()
        {
            dgvPatientAppointments.DataSource = _dtPatientAppointments = await clsAppointment.GetAllByPatientID(PatientID);
            lblRowCount.Text = $"#{_dtPatientAppointments.Rows.Count}";
        }

        public async Task LoadPatientAppointments(int PatientID)
        {
            if (PatientID > 0)
            {
                this._PatientID = PatientID;
                gbAppointments.Values.Description = $"Patient ID = {PatientID}";

                await LoadPatientAppointmentsData();

                if (dgvPatientAppointments.Columns?.Count > 0)
                {
                    foreach (DataGridViewColumn column in dgvPatientAppointments.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
        }

        private void dgvPatientAppointments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvPatientAppointments.Columns["Status"]?.Index && e.Value != null)
            {
                if (e.Value.ToString() == "Scheduled")
                {
                    //e.CellStyle.BackColor = Color.DodgerBlue;
                    e.CellStyle.ForeColor = Color.DodgerBlue;
                }
                else if (e.Value.ToString() == "Waiting")
                {
                    //e.CellStyle.BackColor = Color.DarkOrange;
                    e.CellStyle.ForeColor = Color.DarkOrange;
                }
                else if (e.Value.ToString() == "Completed")
                {
                    //e.CellStyle.BackColor = Color.ForestGreen;
                    e.CellStyle.ForeColor = Color.ForestGreen;
                }
                else if (e.Value.ToString() == "Cancelled")
                {
                    //e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.Red;
                }
                else if (e.Value.ToString() == "No Show")
                {
                    //e.CellStyle.BackColor = Color.DimGray;
                    e.CellStyle.ForeColor = Color.DimGray;
                }
            }
        }

        private void cmsAppointments_Opening(object sender, CancelEventArgs e)
        {
            if (dgvPatientAppointments.SelectedRows.Count > 0)
            {
                StatusCellValue = dgvPatientAppointments.SelectedRows[0].Cells["Status"].Value.ToString();
                showDetailstoolStripMenuItem.Enabled = true;
                if (StatusCellValue == "Completed")
                {
                    checkintoolStripMenuItem.Enabled = rescheduletoolStripMenuItem.Enabled = canceltoolStripMenuItem.Enabled = false;
                }
                else if (StatusCellValue == "No Show")
                {
                    checkintoolStripMenuItem.Enabled = canceltoolStripMenuItem.Enabled = false;
                    rescheduletoolStripMenuItem.Enabled = true;
                }
                else if (StatusCellValue == "Cancelled")
                {
                    checkintoolStripMenuItem.Enabled = rescheduletoolStripMenuItem.Enabled = canceltoolStripMenuItem.Enabled = false;
                }
                else if (StatusCellValue == "Scheduled")
                {
                    checkintoolStripMenuItem.Enabled = rescheduletoolStripMenuItem.Enabled = canceltoolStripMenuItem.Enabled = true;
                }
            }
        }

        private async void reloadtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            await LoadPatientAppointmentsData();
        }

        private void showDetailstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAppointmentDetails frm = new frmAppointmentDetails(Convert.ToInt32(dgvPatientAppointments.SelectedRows[0].Cells["ID"]?.Value));
            frm.ShowDialog();
        }

        private async void schedulenewappointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewEditAppointment frm = new frmAddNewEditAppointment();
            frm.LoadPatient(_PatientID);
            frm.ShowDialog();
        }

        private async void checkintoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewEditPatientCharge frm = new frmAddNewEditPatientCharge();
            await frm.LoadAppointmentDate(Convert.ToInt32(dgvPatientAppointments.SelectedRows[0].Cells["ID"]?.Value));
            frm.ShowDialog();
        }

        private async void rescheduletoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewEditAppointment frm = new frmAddNewEditAppointment(Convert.ToInt32(dgvPatientAppointments.SelectedRows[0].Cells["ID"].Value));
            frm.ShowDialog();
        }

        private async void canceltoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel this appointment?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (await clsAppointment.Cancel(Convert.ToInt32(dgvPatientAppointments.SelectedRows[0].Cells["ID"].Value)))
                    MessageBox.Show("Appointment cancelled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed to cancel the appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
