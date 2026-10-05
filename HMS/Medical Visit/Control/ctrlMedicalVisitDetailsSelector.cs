using HMS.BLL;
using HMS.People;
using HMS.People.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Medical_Visit.Control
{
    public partial class ctrlMedicalVisitDetailsSelector : UserControl
    {
        public event Action<clsMedicalVisit> OnMedicalVisitSelected;

        public clsMedicalVisit MedicalVisitData { get { return ctrlMedicalVisitDetails1.MedicalVisitData; } }

        public ctrlMedicalVisitDetailsSelector()
        {
            InitializeComponent();
        }

        public void DisableFilter()
        {
            this.gbFilter.Visible = false;
        }

        public void EnableFilter()
        {
            this.gbFilter.Visible = true;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbFilter.Text))
            {
                await ctrlMedicalVisitDetails1.LoadMedicalVisitData(Convert.ToInt32(tbFilter.Text));

                if (MedicalVisitData == null)
                    MessageBox.Show($"No Medical Visit found with ID {tbFilter.Text}.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    OnMedicalVisitSelected?.Invoke(MedicalVisitData);
            }
            else
            {
                MessageBox.Show("Please enter a valid ID to search.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //frmAddNewEditMedicalVisit frm = new frmAddNewEditMedicalVisit();
            //frm.OnMedicalVisitDataSaved +=
            //((MedicalVisit) =>
            //{
            //    tbFilter.Text = MedicalVisit.ID.ToString();
            //    ctrlMedicalVisitDetails1.LoadMedicalVisitData(MedicalVisit);
            //    OnMedicalVisitSelected?.Invoke(MedicalVisit);
            //});
            //frm.ShowDialog();
        }

        public async Task LoadMedicalVisitData(int? MedicalVisitID)
        {
            if (MedicalVisitID.HasValue)
            {
                await ctrlMedicalVisitDetails1.LoadMedicalVisitData(MedicalVisitID.Value);
                DisableFilter();
            }
        }

        public void LoadMedicalVisitData(clsMedicalVisit MedicalVisitData)
        {
            if (MedicalVisitData != null)
            {
                ctrlMedicalVisitDetails1.LoadMedicalVisitData(MedicalVisitData);
                DisableFilter();
            }
        }
    }
}
