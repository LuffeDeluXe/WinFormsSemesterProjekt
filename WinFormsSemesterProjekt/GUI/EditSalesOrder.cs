using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsSemesterProjekt.DataBase;
using WinformsSemesterprojekt.Models;
using WinFormsSemesterProjekt.GUI.PopUps;
using Microsoft.IdentityModel.Tokens;

namespace WinFormsSemesterProjekt.GUI
{
    public partial class EditSalesOrder : Form
    {
        public BindingList<ProductLine> orderProductLines { get; set; } = new BindingList<ProductLine>();
        public List<ProductLine> filteredOrderProductLine { get; set; }
        public int CurrentOrderID { get; set; }
        public double TotalPrice { get; set; }
        public EditSalesOrder(int orderID)
        {
            CurrentOrderID = orderID;

            Order order = OrderDB.FindOrder(CurrentOrderID);

            filteredOrderProductLine = ProductLineDatabase.LookInTheDatabase(CurrentOrderID);

            foreach (ProductLine line in filteredOrderProductLine)
            {
                orderProductLines.Add(line);
            }

            InitializeComponent();

            productLineDataView.DataSource = orderProductLines;

            shippingMethodLabel.Text = order.ShippingMethod;
            customerIDLabel.Text = order.OrderID.ToString();
            totalPriceTextBox.Text = order.TotalPrice.ToString();
        }

        /*Updates the total price of the order, to match all products combined in the order*/
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

            if (filteredOrderProductLine.Count <= 0)
            {
                totalPriceTextBox.Text = "0";
            }
            else
            {
                totalPriceTextBox.Text = TotalPrice.ToString();
            }

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
            this.Close();
        }

        /*Updates the order with the new relevant information and closes the EditSalesOrder form*/
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            OrderDB.UpdateOrder(CurrentOrderID, Convert.ToInt32(customerIDLabel.Text), DateTime.Now, "Updated", Convert.ToDouble(totalPriceTextBox.Text), shippingMethodLabel.Text.ToString());
            UpdatedOrder updatedOrder = new UpdatedOrder();
            updatedOrder.Show();
            this.Close();
        }

        /*Takes the ID of the currently selected ProductLine and puts it into the ProductLineID textbox*/
        private void editProductLineButton_Click(object sender, EventArgs e)
        {
            string productLineID = productLineDataView.CurrentRow.Cells[0].Value.ToString();

            productLineIDBox.Text = productLineID;
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

        /*Deletes the currently selected ProductLine*/
        private void deleteProductLineButton_Click(object sender, EventArgs e)
        {
            if (productLineIDBox.Text != null)
            {
                ProductLineDatabase.DeleteProductLine(Convert.ToInt32(productLineDataView.CurrentRow.Cells[0].Value));

                UpDateTotalPrice();
            }
        }

        //Opens the AddProductLine form with reference to the current OrderID and this EditSalesOrder form
        private void buttonAddProducts_Click(object sender, EventArgs e)
        {
            WinAddProductLine addProductLine = new WinAddProductLine(CurrentOrderID, this);
            addProductLine.Show();
        }
    }
}
