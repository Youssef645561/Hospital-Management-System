using HMS.Appointment.Control;
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
using Youssef.WinForms.Controls;

namespace HMS.Payment
{
    public partial class frmPaymentsHistory : JOSubForm
    {
        int? PatientChargeID { get; set; }
        clsPatientCharge.enStatus Status { get; set; }
        public frmPaymentsHistory(int? PatientChargeID, clsPatientCharge.enStatus Status)
        {
            InitializeComponent();
            this.PatientChargeID = PatientChargeID;
            this.Status = Status;
        }

        private async void frmPaymentsHistory_Load(object sender, EventArgs e)
        {
            if (PatientChargeID.HasValue && PatientChargeID > 0)
                await ctrlPaymentsHistory1.LoadPayments(PatientChargeID.Value, Status);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
