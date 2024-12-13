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
        public int CurrentOrderID { get; private set; }
        public BindingList<ProductLine> orderProductLines { get; set; } = new BindingList<ProductLine>();
        public List<ProductLine> filteredOrderProductLine { get; set; }
        public double TotalPrice { get; private set; }
        public AddSalesOrder()
        {
            InitializeComponent();

            filteredOrderProductLine = ProductLineDatabase.LookInTheDatabase(CurrentOrderID);

            foreach (ProductLine line in filteredOrderProductLine)
            {
                orderProductLines.Add(line);
            }

            productLineDataView.DataSource = orderProductLines;

            shippingComboBox.SelectedIndex = 0;
        }

        private void UpDateTotalPrice()
        {
            foreach (ProductLine line in filteredOrderProductLine)
            {
                TotalPrice += line.PricePerUnit * line.Quantity;
            }
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
            WinAddProductLine productLine = new WinAddProductLine(CurrentOrderID);
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
    }
}
