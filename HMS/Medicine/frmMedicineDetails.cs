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

namespace HMS.Medicine
{
    public partial class frmMedicineDetails : JOSubForm
    {
        int ID {  get; set; }
        public frmMedicineDetails(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private async void frmMedicineDetails_Load(object sender, EventArgs e)
        {
            await ctrlMedicineDetails1.LoadMedicineData(ID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
