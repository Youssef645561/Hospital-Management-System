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

namespace HMS.People.Control
{
    public partial class ctrlPersonDetailsSelector : UserControl
    {
        public event Action<clsPerson> OnPersonSelected;

        public clsPerson PersonData { get { return ctrlPersonDetails1.PersonData; } }

        public ctrlPersonDetailsSelector()
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
                await ctrlPersonDetails1.LoadPersonData(Convert.ToInt32(tbFilter.Text));

                if (PersonData == null)
                    MessageBox.Show($"No person found with ID {tbFilter.Text}.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    OnPersonSelected?.Invoke(PersonData);
            }
            else
            {
                MessageBox.Show("Please enter a valid ID to search.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddNewEditPerson frm = new frmAddNewEditPerson();
            frm.OnPersonDataSaved +=
            ((person) =>
             {
                 tbFilter.Text = person.ID.ToString();
                 ctrlPersonDetails1.LoadPersonData(person);
                 OnPersonSelected?.Invoke(person);
             });
            frm.ShowDialog();
        }

        public async Task LoadPersonData(int? personID)
        {
            if (personID.HasValue)
            {
                await ctrlPersonDetails1.LoadPersonData(personID.Value);
                DisableFilter();
            }
        }
    }
}
