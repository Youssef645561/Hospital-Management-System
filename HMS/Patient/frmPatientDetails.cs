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

namespace HMS.Patients
{
    public partial class frmPatientDetails : JOSubForm
    {
        int ID { get; set; }
        public frmPatientDetails(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private async void frmPatientDetails_Load(object sender, EventArgs e)
        {
            await ctrlPatientDetails1.LoadPatientData(ID);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
