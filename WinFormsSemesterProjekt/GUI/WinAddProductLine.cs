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
        public BindingList<Product> FilteredList { get; private set; } = new BindingList<Product>();
        private int OrderLineID { get; set; }
        private AddSalesOrder CurrentAddSalesOrder { get; set; }
        private EditSalesOrder CurrentEditSalesOrder { get; set; }
        private string AddOrEditOrder {  get; set; }
        public WinAddProductLine(int orderID, AddSalesOrder addSalesOrder)
        {
            InitializeComponent();

            ProductList = new BindingList<Product>(ProductDatabase.FindAllProducts());

            CurrentAddSalesOrder = addSalesOrder;
            AddOrEditOrder = "Add";

            OrderLineID = orderID;

            pLProductView.DataSource = ProductList;
            plProductSearchBar.Text = "Indtast produkt id...";
            plProductSearchBar.ForeColor = Color.Gray;
        }

        public WinAddProductLine(int orderID, EditSalesOrder editSalesOrder)
        {
            InitializeComponent();

            ProductList = new BindingList<Product>(ProductDatabase.FindAllProducts());

            CurrentEditSalesOrder = editSalesOrder;
            AddOrEditOrder = "Edit";

            OrderLineID = orderID;

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
                Product foundProduct = ProductDatabase.FindProduct(convertedInput);

                FilteredList.Clear();

                FilteredList.Add(foundProduct);

                pLProductView.DataSource = FilteredList;

                pLProductView.Refresh();
            }
        }

        private void pLAddProductButton_Click(object sender, EventArgs e)
        {
            string productID = pLProductView.CurrentRow.Cells[0].Value.ToString();

            pLProductIDTextBox.Text = productID;

            string productName = pLProductView.CurrentRow.Cells[1].Value.ToString();

            pLProductNameBox.Text = productName;

            double unitPrice = Convert.ToDouble(pLProductView.CurrentRow.Cells[4].Value);

            pLPricePrUnitTextBox.Text = unitPrice.ToString();

            string productDescription = pLProductView.CurrentRow.Cells[3].Value.ToString();

            pLProductDescriptionBox.Text = productDescription;

            pLProductQuantityNumeric.Value = 1;
        }

        private void productLineCreateButton_Click(object sender, EventArgs e)
        {
            ProductLine productLine = new ProductLine(OrderLineID, Convert.ToInt32(pLProductIDTextBox.Text), Convert.ToInt32(pLProductQuantityNumeric.Value), Convert.ToDouble(pLPricePrUnitTextBox.Text));

            int newStock = Convert.ToInt32(pLProductView.CurrentRow.Cells[5].Value) - Convert.ToInt32(pLProductQuantityNumeric.Value);

            ProductDatabase.UpdateProduct(Convert.ToInt32(pLProductIDTextBox.Text), pLProductNameBox.Text, pLProductView.CurrentRow.Cells[2].Value.ToString(), pLProductDescriptionBox.Text, Convert.ToDouble(pLProductView.CurrentRow.Cells[4].Value), newStock);

            if (AddOrEditOrder == "Add")
            {
                CurrentAddSalesOrder.UpDateTotalPrice();
            }

            if (AddOrEditOrder == "Edit")
            {
                CurrentEditSalesOrder.UpDateTotalPrice();
            }

            this.Close();
        }
    }
}
