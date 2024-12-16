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

namespace WinFormsSemesterProjekt.GUI.PopUps
{
    public partial class ConfirmDeletionOrder : Form
    {
        private Orders CurrentOrders {  get; set; }
        private int CurrentOrderID { get; set; }
        public ConfirmDeletionOrder(int orderID, Orders orders)
        {
            CurrentOrders = orders;
            CurrentOrderID = orderID;

            InitializeComponent();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            List<ProductLine> lines = ProductLineDatabase.LookInTheDatabase(CurrentOrderID);

            foreach (ProductLine line in lines)
            {
                ProductLineDatabase.DeleteProductLine(line.ProductLineID);
            }

            OrderDB.DeleteOrder(CurrentOrderID);

            CurrentOrders.UpdateOrderList();

            DeletedOrder deletedOrder = new DeletedOrder();
            deletedOrder.Show();
            this.Close();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
