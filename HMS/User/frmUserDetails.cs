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

namespace HMS.Users
{
    public partial class frmUserDetails : JOSubForm
    {
        private int ID;
        private clsUser _UserData { get; set; } = null;

        public frmUserDetails(int id)
        {
            InitializeComponent();
            ID = id;
        }
        public frmUserDetails(clsUser UserData)
        {
            InitializeComponent();
            _UserData = UserData;
        }

        private async void frmUserDetails_Load(object sender, EventArgs e)
        {
            if (_UserData != null)
                ctrlUserDetails1.LoadUserData(_UserData);
            else
                await ctrlUserDetails1.LoadUserData(ID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
