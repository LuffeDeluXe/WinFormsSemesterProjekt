using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsSemesterprojekt.Models;
using WinFormsSemesterProjekt.DataBase;

namespace WinFormsSemesterProjekt.GUI
{
    public partial class WinAddProductLine : Form
    {
        public BindingList<Product> ProductList { get; set; }
        public BindingList<Product> FilteredList { get; set; } = new BindingList<Product>();
        public WinAddProductLine()
        {
            InitializeComponent();

            ProductList = new BindingList<Product>(ProductDatabase.FindAllProducts());

            pLProductView.DataSource = ProductList;
            plProductSearchBar.Text = "Indtast produkt id...";
            plProductSearchBar.ForeColor = Color.Gray;
        }


        private void PLSearchBar_Leave(object sender, EventArgs e)
        {
            if (plProductSearchBar.Text == "Indtast produkt id..." || String.IsNullOrEmpty(plProductSearchBar.Text))
            {
                plProductSearchBar.Text = "Indtast produkt id...";
                plProductSearchBar.ForeColor = Color.Gray;

                pLProductView.DataSource = ProductList;

                pLProductView.Refresh();
            }
        }

        private void PLSearchBar_Enter(object sender, EventArgs e)
        {
            if (plProductSearchBar.Text == "Indtast produkt id..." || String.IsNullOrEmpty(plProductSearchBar.Text))
            {
                plProductSearchBar.Text = "";
                plProductSearchBar.ForeColor = Color.Black;

                pLProductView.DataSource = ProductList;

                pLProductView.Refresh();
            }
        }

        private void pLSearchProductButton_Click(object sender, EventArgs e)
        {
            string searchInput = plProductSearchBar.Text;

            if (int.TryParse(searchInput, out int convertedInput))
            {

            }
        }
    }
}
