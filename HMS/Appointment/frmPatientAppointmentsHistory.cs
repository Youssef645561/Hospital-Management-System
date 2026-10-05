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

namespace HMS.Appointment
{
    public partial class frmPatientAppointmentsHistory : JOSubForm
    {
        int? PatientID { get; set; }

        public frmPatientAppointmentsHistory(int? PatientID)
        {
            InitializeComponent();
            this.PatientID = PatientID;
        }

        private async void frmPatientAppointmentsHistory_Load(object sender, EventArgs e)
        {
            if (PatientID.HasValue && PatientID > 0)
                await ctrlPatientAppointmentsHistory1.LoadPatientAppointments(PatientID.Value);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
