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
using WinFormsSemesterProjekt.GUI;
using WinFormsSemesterProjekt.GUI.PopUps;

namespace WinFormsSemesterProjekt
{
    public partial class Orders : Form
    {
        public BindingList<Order> orderList { get; set; } = new BindingList<Order>();
        public List<Order> listOfOrders { get; set; } = new List<Order>();
        public Orders()
        {
            UpdateOrderList();

            InitializeComponent();

            dataGridView1.DataSource = orderList;
        }

        public void UpdateOrderList()
        {
            orderList.Clear();

            if (listOfOrders.Count <= 0)
            {
                listOfOrders.Clear();
            }

            listOfOrders = OrderDB.FindAllOrders();

            foreach (Order order in listOfOrders)
            {
                orderList.Add(order);
            }
        }

        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            OrderTypeSelection orderTypeSelection = new OrderTypeSelection();
            orderTypeSelection.Show();
            this.Close();
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            ConfirmDeletionOrder confirmDeletionOrder = new ConfirmDeletionOrder(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), this);
            confirmDeletionOrder.Show();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (orderSearchBar.Text != null)
            {
                int orderID = Convert.ToInt32(orderSearchBar.Text);

                Order order = OrderDB.FindOrder(orderID);

                orderList.Clear();
                orderList.Add(order);

                dataGridView1.Refresh();
            }

        }

        private void buttonEditOrder_Click(object sender, EventArgs e)
        {
            EditSalesOrder editSalesOrder = new EditSalesOrder(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            editSalesOrder.Show();
            this.Close();
        }
    }
}
