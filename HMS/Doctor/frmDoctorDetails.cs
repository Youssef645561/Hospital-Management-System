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

namespace HMS.Doctors
{
    public partial class frmDoctorDetails : JOSubForm
    {
        int ID {  get; set; }
        public frmDoctorDetails(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmDoctorDetails_Load(object sender, EventArgs e)
        {
            await ctrlDoctorDetails1.LoadDoctorData(ID);
        }
    }
}
