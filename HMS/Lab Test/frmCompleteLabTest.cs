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

namespace HMS.Lab_Test
{
    public partial class frmCompleteLabTest : JOSubForm
    {
        int? LabTestID { get; set; }

        public frmCompleteLabTest(int? LabTestID)
        {
            InitializeComponent();
            this.LabTestID = LabTestID;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (await clsLabTest.CompleteLabTest(LabTestID, rbPositive.Checked, string.IsNullOrWhiteSpace(tbNotes.Text) ? null : tbNotes.Text))
            {
                MessageBox.Show("Lab test completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to complete the lab test. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
