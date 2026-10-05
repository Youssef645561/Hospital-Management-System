using HMS.BLL;
using HMS.Patient.Control;
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
using Youssef.WinForms.Controls;

namespace HMS.Prescription
{
    public partial class frmAddNewEditPrescription : JOSubForm
    {
        public event Action<clsPrescription> OnPrescriptionDataSaved;

        private DataTable dtMedicines { get; set; } = null;

        int? ID { get; set; } = null;

        public enum enMode { AddNew, Edit }
        private enMode? _Mode;

        clsPrescription _PrescriptionData = null;

        public frmAddNewEditPrescription()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddNewEditPrescription(int? ID)
        {
            InitializeComponent();
            _Mode = enMode.Edit;
            this.ID = ID;
        }
        public frmAddNewEditPrescription(clsPrescription PrescriptionData)
        {
            InitializeComponent();
            _Mode = enMode.Edit;
            this._PrescriptionData = PrescriptionData;
        }

        private void LinkdgvDataSource(DataTable dt)
        {
            dtMedicines = dt;
            dgvMedicines.DataSource = dtMedicines;

            if (dgvMedicines.Columns?.Count > 0)
            {
                foreach (DataGridViewColumn column in dgvMedicines.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void AddMedicineRow(DataRow row)
        {
            DataRow newRow = dtMedicines.NewRow();

            for (int i = 0; i < row.ItemArray.Length; i++)
            {
                newRow[i] = row[i];
            }

            dtMedicines.Rows.Add(newRow);
            lblRowCount.Text = $"#{dtMedicines.Rows.Count}";
        }

        private bool IsRowAlreadyAdded(DataRow sourceRow)
        {
            return dtMedicines.Select().Any(row => row["ID"].Equals(sourceRow["ID"]));
        }

        private void MedicineSelected(DataRow row, DataTable dt)
        {
            if (dtMedicines == null)
                dtMedicines = dt.Clone();

            if (!IsRowAlreadyAdded(row))
            {
                AddMedicineRow(row);

                if (dgvMedicines.DataSource == null)
                    LinkdgvDataSource(dtMedicines);
            }
        }

        private async void MedicalVisitSelected(clsMedicalVisit MedicalVisit)
        {
            if (MedicalVisit?.PrescriptionID != _PrescriptionData?.ID)
            {
                if (!await clsMedicalVisit.HasPrescription(MedicalVisit.ID))
                {
                    btnNext.Enabled = btnSave.Enabled = true;
                }
                else
                {
                    btnNext.Enabled = btnSave.Enabled = false;
                    MessageBox.Show("The selected Medical Visit has already a Prescription.", "Duplicate Prescription", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                btnNext.Enabled = btnSave.Enabled = true;
        }

        public void LoadMedicalVisitData(clsMedicalVisit MedicalVisit)
        {
            ctrlMedicalVisitDetailsSelector1.LoadMedicalVisitData(MedicalVisit);
        }

        private async void frmAddNewEditPrescription_Load(object sender, EventArgs e)
        {
            dgvMedicines.DataSource = null;

            tcAddNewEditPrescription.Appearance = TabAppearance.FlatButtons;
            tcAddNewEditPrescription.ItemSize = new Size(0, 1);
            tcAddNewEditPrescription.SizeMode = TabSizeMode.Fixed;

            dtpExpirationDate.CustomFormat = "dd/MM/yyyy";

            ctrlMedicineSelector1.OnRowSelected += MedicineSelected;

            ctrlMedicalVisitDetailsSelector1.OnMedicalVisitSelected += MedicalVisitSelected;

            await ctrlMedicineSelector1.Initialize();

            if (ID.HasValue)
                _PrescriptionData = await clsPrescription.Find(ID);

            if (_Mode == enMode.AddNew)
                ShowAddNewScreen();
            else
            {
                if (_PrescriptionData != null)
                    ShowEditScreen();
                else
                    DisableScreen();
            }
        }

        private void lblTitle_SizeChanged(object sender, EventArgs e)
        {
            lblTitle.Left = (this.Width - lblTitle.Width) / 2;
        }

        private void ShowAddNewScreen()
        {
            _Mode = enMode.AddNew;
            _PrescriptionData = new clsPrescription();
            this.Text = lblTitle.Text = "Add New Prescription";
            gbPrescriptionData.Values.Description = "ID : ???";

            if (ctrlMedicalVisitDetailsSelector1.MedicalVisitData == null)
                ctrlMedicalVisitDetailsSelector1.EnableFilter();
        }

        private void DisableScreen()
        {
            this._PrescriptionData = null;
            gbPrescriptionData.Enabled = btnSave.Enabled = false;
            ctrlMedicalVisitDetailsSelector1.Enabled = false;
            MessageBox.Show("Prescription data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void ShowEditScreen()
        {
            _Mode = enMode.Edit;

            this.Text = lblTitle.Text = "Edit Prescription";

            if (_PrescriptionData != null)
            {
                ctrlMedicalVisitDetailsSelector1.DisableFilter();
                gbPrescriptionData.Values.Description = $"ID : {_PrescriptionData.ID}";


                if (ctrlMedicalVisitDetailsSelector1.MedicalVisitData == null)
                    await ctrlMedicalVisitDetailsSelector1.LoadMedicalVisitData(_PrescriptionData.MedicalVisitID);

                LinkdgvDataSource(_PrescriptionData.dtMedicines);

                cbStatus.SelectedIndex = (int)_PrescriptionData.Status - 1;
                cbStatus.Enabled = true;
                dtpExpirationDate.Value = _PrescriptionData.ExpirationDate.Value;

                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
                MessageBox.Show("No Prescription selected for editing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ctrlMedicalVisitDetailsSelector1.MedicalVisitData != null)
            {
                _PrescriptionData.MedicalVisitID = ctrlMedicalVisitDetailsSelector1.MedicalVisitData.ID;
                if (_Mode == enMode.AddNew)
                {
                    _PrescriptionData.CreatedByUserID = clsGlobal.CurrentUser.ID;
                    _PrescriptionData.CreatedByUsername = clsGlobal.CurrentUser.Username;
                }

                _PrescriptionData.ExpirationDate = dtpExpirationDate.Value.Date;
                _PrescriptionData.Status = (clsPrescription.enStatus)(cbStatus.SelectedIndex + 1);
                _PrescriptionData.dtMedicines = dtMedicines;

                if (await _PrescriptionData.Save())
                {
                    ShowEditScreen();
                    OnPrescriptionDataSaved?.Invoke(_PrescriptionData);
                    MessageBox.Show("Prescription data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Failed to save Prescription data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please select a Medical Visit before saving.", "No MedicalVisit Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrlMedicalVisitDetailsSelector1.MedicalVisitData != null)
                tcAddNewEditPrescription.SelectedTab = tpMedicinesData;
            else
                MessageBox.Show("Please select a Medical Visit first.", "Medical Visit Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcAddNewEditPrescription.SelectedTab = tpMedicalVisitData;
        }

        private void dgvMedicines_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvMedicines.Columns["Active"]?.Index && e.Value != null)
            {
                if (e.Value.ToString() == "Active")
                {
                    //e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if (e.Value.ToString() == "Inactive")
                {
                    //e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void RemovetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMedicines.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to remove this medicine ?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dtMedicines.Rows.Remove(dtMedicines.Select().Where(row => row["ID"].Equals(dgvMedicines.SelectedRows[0].Cells["ID"].Value)).FirstOrDefault());
                }

            }
        }
    }
}
