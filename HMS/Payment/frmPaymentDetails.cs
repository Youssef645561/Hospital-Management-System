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
    public partial class frmPaymentDetails : JOSubForm
    {
        int ID { get; set; }
        public frmPaymentDetails(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmPaymentDetails_Load(object sender, EventArgs e)
        {
            await ctrlPaymentDetails1.LoadPaymentData(ID);
        }
    }
}
