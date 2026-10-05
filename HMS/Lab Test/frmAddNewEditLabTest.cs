using HMS.BLL;
using HMS.Prescription;
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
    public partial class frmAddNewEditLabTest : JOSubForm
    {
        public event Action<clsLabTest> OnLabTestDataSaved;

        int? AppointmentID { get; set; }

        clsLabTest _LabTestData = null;

        public frmAddNewEditLabTest(int? AppointmentID)
        {
            InitializeComponent();
            this.AppointmentID = AppointmentID;
        }

        private async Task LoadTestTypes()
        {
            cbTestTypes.DataSource = await clsTestType.GetAll();
            cbTestTypes.DisplayMember = "Name";
            cbTestTypes.ValueMember = "ID";
        }

        public async void frmAddNewEditLabTest_Load(object sender, EventArgs e)
        {
            await LoadTestTypes();

            _LabTestData = new clsLabTest();
        }

        public void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            byte? TestTypeID = Convert.ToByte(cbTestTypes.SelectedValue);

            if (await clsAppointment.HasLabTest(AppointmentID, TestTypeID))
            {
                MessageBox.Show("A lab test of this type already exists for the selected appointment.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _LabTestData.TestTypeID = TestTypeID;
            _LabTestData.AppointmentID = AppointmentID;
            _LabTestData.CreatedByUserID = clsGlobal.CurrentUser.ID;

            if (await _LabTestData.Save())
            {
                MessageBox.Show("Lab test added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add the lab test.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
