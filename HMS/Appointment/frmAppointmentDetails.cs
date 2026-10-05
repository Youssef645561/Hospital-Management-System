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

namespace HMS.Appointment
{
    public partial class frmAppointmentDetails : JOSubForm
    {
        int ID { get; set; }
        public frmAppointmentDetails(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmAppointmentDetails_Load(object sender, EventArgs e)
        {
            await ctrlAppointmentDetails1.LoadAppointmentData(ID);
        }
    }
}
