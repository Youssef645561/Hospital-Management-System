using HMS.Appointment;
using HMS.BLL;
using HMS.Doctors;
using HMS.Lab_Test;
using HMS.Medical_Visit;
using HMS.Medicine;
using HMS.Patient;
using HMS.Patient_Charge;
using HMS.Patients;
using HMS.Payment;
using HMS.People;
using HMS.Prescription;
using HMS.User_Roles;
using HMS.Users;
using Krypton.Toolkit;
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

namespace HMS
{
    public partial class frmMain : JOBaseForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            lblTitle.Left = (gbMain.Width - lblTitle.Width) / 2;
        }

        private void PeopletoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManagePeople().ShowDialog();
        }

        private void DoctorstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageDoctors().ShowDialog();
        }

        private void PatientstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManagePatients().ShowDialog();
        }

        private void PatientQueuetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageWaitings().ShowDialog();
        }

        private void AppointmentstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageAppointments().ShowDialog();
        }

        private void LaboratorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageLabTests().ShowDialog();
        }

        private void MedicalVisitstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageMedicalVisits().ShowDialog();
        }

        private void PrescriptionstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManagePrescriptions().ShowDialog();
        }

        private void MedicinestoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageMedicines().ShowDialog();
        }

        private void PatientChargestoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManagePatientCharges().ShowDialog();
        }

        private void PaymentstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManagePayments().ShowDialog();
        }

        private void UserstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageUsers().ShowDialog();
        }

        private void RolestoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageUserRoles().ShowDialog();
        }

        private void ProfiletoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmUserDetails(clsGlobal.CurrentUser).ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmChangeUserPassword(clsGlobal.CurrentUser).ShowDialog();
        }
    }
}
