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

namespace HMS.Medical_Visit
{
    public partial class frmMedicalVisitDetails : JOSubForm
    {
        int ID { get; set; }
        public frmMedicalVisitDetails(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private async void frmMedicalVisitDetails_Load(object sender, EventArgs e)
        {
            await ctrlMedicalVisitDetails1.LoadMedicalVisitData(ID);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
