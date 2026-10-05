using HMS.Doctors.Controls;
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

namespace HMS.Patient_Charge
{
    public partial class frmPatientChargeDetails : JOSubForm
    {
        int ID { get; set; }

        public frmPatientChargeDetails(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmPatientChargeDetails_Load(object sender, EventArgs e)
        {
            await ctrlPatientChargeDetails1.LoadPatientChargeData(ID);
        }
    }
}
