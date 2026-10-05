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

namespace HMS.Prescription
{
    public partial class frmPrescriptionDetails : JOSubForm
    {
        int ID { get; set; }
        public frmPrescriptionDetails(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmPrescriptionDetails_Load(object sender, EventArgs e)
        {
            await ctrlPrescriptionDetails1.LoadPrescriptionData(ID);
        }
    }
}
