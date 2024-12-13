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
using WinFormsSemesterProjekt.GUI.PopUps;

namespace WinFormsSemesterProjekt.GUI
{
    public partial class AddSalesOrder : Form
    {
        public BindingList<ProductLine> orderProductLines { get; set; } = new BindingList<ProductLine>();
        public AddSalesOrder()
        {
            InitializeComponent();

            productLineDataView.DataSource = orderProductLines;

            shippingComboBox.SelectedItem = 0;
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
            WinAddProductLine productLine = new WinAddProductLine();
            productLine.Show();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            Order order = new Order(Convert.ToInt32(customerIDTextBox.Text), DateTime.Now, DateTime.Now, "Created", 0, shippingComboBox.SelectedItem.ToString());
            orderIDLabel.Text = order.OrderID.ToString();
            orderLabel.Visible = true;
            orderIDLabel.Visible = true;
        }
    }
}
