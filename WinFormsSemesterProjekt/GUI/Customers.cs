using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsSemesterProjekt.GUI.PopUps;

namespace WinFormsSemesterProjekt
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void searchBar_Leave(object sender, EventArgs e)
        {
            if (searchBar.Text == "")
            {
                searchBar.Text = "Søg efter en kunde...";
                searchBar.ForeColor = Color.Black;
            }
        }

        private void searchBar_Enter(object sender, EventArgs e)
        {
            if (searchBar.Text == "Søg efter en kunde...")
            {
                searchBar.Text = "";
                searchBar.ForeColor = Color.LightGray;
            }
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            ConfirmDeletionCustomer confirmDeletionCustomer = new ConfirmDeletionCustomer();
            confirmDeletionCustomer.Show();
        }
    }
}
