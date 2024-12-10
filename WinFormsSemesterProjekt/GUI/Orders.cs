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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void searchBar_Leave(object sender, EventArgs e)
        {
            if (searchBar.Text == "")
            {
                searchBar.Text = "Indtast ordrenummer...";
                searchBar.ForeColor = Color.Black;
            }
        }

        private void searchBar_Enter(object sender, EventArgs e)
        {
            if (searchBar.Text == "Indtast ordrenummer...")
            {
                searchBar.Text = "";
                searchBar.ForeColor = Color.LightGray;
            }
        }

        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            OrderTypeSelection orderTypeSelection = new OrderTypeSelection();
            orderTypeSelection.Show();
        }
    }
}
