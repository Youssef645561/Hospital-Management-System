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

namespace HMS.People
{
    public partial class frmPersonDetails : JOSubForm
    {
        int ID;
        public frmPersonDetails(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private async void frmShowPersonDetails_Load(object sender, EventArgs e)
        {
            await ctrlPersonDetails1.LoadPersonData(ID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
