using HMS.BLL;
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
    public partial class frmManageMedicines : JOSubForm
    {
        public frmManageMedicines()
        {
            InitializeComponent();
        }

        private async void frmManageMedicines_Load(object sender, EventArgs e)
        {
            await ctrlMedicineSelector1.Initialize();
        }
    }
}
