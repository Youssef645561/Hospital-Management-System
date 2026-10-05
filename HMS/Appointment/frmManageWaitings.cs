using Common;
using HMS.BLL;
using HMS.Medical_Visit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Youssef.WinForms.Controls;

namespace HMS.Appointment
{
    public partial class frmManageWaitings : JOSubForm
    {
        bool IsFiltered = false, IsAppointmentStatusesLoading = false, IsAppointmentTypesLoading = false;

        DataTable dtWaitings = new DataTable();

        public frmManageWaitings()
        {
            InitializeComponent();
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            await LoadWaitingsDataFromDB();
        }

        private async Task LoadWaitingsDataFromDB()
        {
            dtWaitings?.Clear();
            dtWaitings.Merge(await clsAppointment.GetAllWatings());
        }

        private string GetFilter()
        {
            switch (cbFilter.Text.Trim())
            {
                case "None":
                    return string.Empty;
                case "ID":
                    return $"ID = {tbFilter.Text}";
                case "Medical Record No":
                    return $"[Medical Record No] like '{tbFilter.Text.Replace("'", "''")}%'";
                default:
                    return string.Empty;
            }
        }

        private void ShowFilteredData()
        {
            dtWaitings.DefaultView.RowFilter = IsFiltered ? GetFilter() : string.Empty;
        }

        private async void tbFilter_TextChanged(object sender, EventArgs e)
        {
            IsFiltered = (!string.IsNullOrWhiteSpace(tbFilter.Text));
            ShowFilteredData();
        }
        
        private async void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsFiltered = false;

            switch (cbFilter.Text)
            {
                case "None":
                    tbFilter.Visible = false;
                    tbFilter.Text = string.Empty;
                    ShowFilteredData();
                    break;
                case "ID":
                    tbFilter.Visible = true;

                    tbFilter.AllowLetters = tbFilter.AllowSpecialCharacters = false;
                    tbFilter.AllowDigits = true;
                    break;
                case "Medical Record No":
                    tbFilter.Visible = true;

                    tbFilter.AllowSpecialCharacters = false;
                    tbFilter.AllowLetters = tbFilter.AllowDigits = true;
                    break;
            }
            tbFilter.Text = string.Empty;
            tbFilter.Focus();
        }

        private void startvisittoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewEditMedicalVisit frm = new frmAddNewEditMedicalVisit();
            frm.AddNewMedicalVisit(Convert.ToInt32(dgvWaitings.SelectedRows[0].Cells["ID"].Value));
            frm.ShowDialog();
        }

        private void dgvWaitings_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value?.ToString() == "Waiting")
            {
                //e.CellStyle.BackColor = Color.DarkOrange;
                e.CellStyle.ForeColor = Color.DarkOrange;
            }
        }

        private async void frmManageWaitings_Load(object sender, EventArgs e)
        {
            await LoadWaitingsDataFromDB();
            dgvWaitings.DataSource = dtWaitings;

            dtWaitings.DefaultView.ListChanged += DefaultView_ListChanged;

            if (dgvWaitings.Columns?.Count > 0)
            {
                foreach (DataGridViewColumn column in dgvWaitings.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void DefaultView_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblRowCount.Text = dgvWaitings.Rows.Count.ToString();
        }
    }
}
