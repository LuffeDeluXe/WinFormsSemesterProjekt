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
using WinFormsSemesterProjekt.GUI.PopUps;

namespace WinFormsSemesterProjekt.GUI
{
    public partial class AddSalesOrder : Form
    {
        public BindingList<ProductLine> orderProductLines { get; set; } = new BindingList<ProductLine>();
        public List<ProductLine> filteredOrderProductLine { get; set; }
        public int CurrentOrderID { get; private set; }
        public double TotalPrice { get; private set; }
        public AddSalesOrder()
        {
            InitializeComponent();

            productLineDataView.DataSource = orderProductLines;

            shippingComboBox.SelectedIndex = 0;
        }

        public void UpDateTotalPrice()
        {
            orderProductLines.Clear();

            filteredOrderProductLine = ProductLineDatabase.LookInTheDatabase(CurrentOrderID);

            foreach (ProductLine line in filteredOrderProductLine)
            {
                orderProductLines.Add(line);
            }

            foreach (ProductLine line in filteredOrderProductLine)
            {
                TotalPrice += line.PricePerUnit * line.Quantity;
            }

            productLineDataView.Refresh();

            totalPriceTextBox.Text = TotalPrice.ToString();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
            this.Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CreatedOrder createdOrder = new CreatedOrder();
            createdOrder.Show();
            this.Close();
        }

        private void buttonAddProducts_Click(object sender, EventArgs e)
        {
            WinAddProductLine productLine = new WinAddProductLine(CurrentOrderID, this);
            productLine.Show();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            Order order = new Order(Convert.ToInt32(customerIDTextBox.Text), DateTime.Now, DateTime.Now, "Created", 0, shippingComboBox.SelectedItem.ToString());
            orderIDLabel.Text = order.OrderID.ToString();
            CurrentOrderID = order.OrderID;
            orderLabel.Visible = true;
            orderIDLabel.Visible = true;
        }

        private void updateProductLineButton_Click(object sender, EventArgs e)
        {
            if (productLineIDBox.Text != null && newQuantityBox.Text != null)
            {
                ProductLine.UpdateQuantity(Convert.ToInt32(productLineIDBox.Text), Convert.ToInt32(newQuantityBox.Text));
                UpDateTotalPrice();
            }

        }

        private void editProductLineButton_Click(object sender, EventArgs e)
        {
            string productLineID = productLineDataView.CurrentRow.Cells[0].Value.ToString();

            productLineIDBox.Text = productLineID;
        }
    }
}
