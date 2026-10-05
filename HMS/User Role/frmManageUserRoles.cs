using HMS.BLL;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Youssef.WinForms.Controls;

namespace HMS.User_Roles
{
    public partial class frmManageUserRoles : JOSubForm
    {
        public frmManageUserRoles()
        {
            InitializeComponent();
        }

        private async Task LoadUserRoles()
        {
            dgvUserRoles.DataSource = await clsUserRole.GetAll();
            lblRowCount.Text = $"#{dgvUserRoles.Rows.Count}";
        }

        private async void frmManageUserRoles_Load(object sender, EventArgs e)
        {
            await LoadUserRoles();

            if (dgvUserRoles.Columns?.Count > 0)
            {
                foreach (DataGridViewColumn column in dgvUserRoles.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            await LoadUserRoles();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddNewEditUserRole().ShowDialog();
        }

        private void edittoolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddNewEditUserRole(Convert.ToByte(dgvUserRoles.SelectedRows[0].Cells["ID"].Value)).ShowDialog();
        }
    }
}
