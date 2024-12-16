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

        /*Updates the TotalPrice textbox to show the total price
          Of all products combined, in the current order*/
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

        //Opens a new Orders form and closes this form
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
            this.Close();
        }

        /*Updates the current order with all the necessary information,
          Opens a new Orders form and closes this form*/
        private void buttonFinish_Click(object sender, EventArgs e)
        {
            OrderDB.UpdateOrder(CurrentOrderID, Convert.ToInt32(customerIDTextBox.Text), DateTime.Now, "Created", Convert.ToDouble(totalPriceTextBox.Text), shippingComboBox.SelectedItem.ToString());
            CreatedOrder createdOrder = new CreatedOrder();
            createdOrder.Show();
            this.Close();
        }

        //Opens the AddProductLine form with reference to the current OrderID and this form
        private void buttonAddProducts_Click(object sender, EventArgs e)
        {
            WinAddProductLine addProductLine = new WinAddProductLine(CurrentOrderID, this);
            addProductLine.Show();
        }

        /*Creates an Order with the CustomerID set in the customerID textbox,
          Takes the current time as order and delivery date, sets status to "Created",
          And by standard sets the shipping method to "Pickup Point"
        
          It then sets the orderID label to show the current orderID*/
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            Order order = new Order(Convert.ToInt32(customerIDTextBox.Text), DateTime.Now, DateTime.Now, "Created", 0, shippingComboBox.SelectedItem.ToString());
            orderIDLabel.Text = order.OrderID.ToString();
            CurrentOrderID = order.OrderID;
            orderLabel.Visible = true;
            orderIDLabel.Visible = true;
        }

        /*Updates the Productline corresponding to the input in ProductLineID textbox
          And changes the quantity to correspond with the input in the NewQuantity textbox*/
        private void updateProductLineButton_Click(object sender, EventArgs e)
        {
            if (productLineIDBox.Text != null && newQuantityBox.Text != null)
            {
                if (Convert.ToInt32(newQuantityBox.Text) == 0)
                {
                    ProductLineDatabase.DeleteProductLine(Convert.ToInt32(productLineIDBox.Text));
                }
                else
                {
                    ProductLine.UpdateQuantity(Convert.ToInt32(productLineIDBox.Text), Convert.ToInt32(newQuantityBox.Text));
                }

                UpDateTotalPrice();
            }

        }

        /*Takes the ID of the currently selected ProductLine and puts it into the ProductLineID textbox*/
        private void editProductLineButton_Click(object sender, EventArgs e)
        {
            string productLineID = productLineDataView.CurrentRow.Cells[0].Value.ToString();

            productLineIDBox.Text = productLineID;
        }
    }
}
