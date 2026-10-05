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

namespace HMS.Lab_Test
{
    public partial class frmLabTestDetails : JOSubForm
    {
        int ID { get; set; }

        public frmLabTestDetails(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private async void frmLabTestDetails_Load(object sender, EventArgs e)
        {
            await ctrlLabTestDetails1.LoadLabTestData(ID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
