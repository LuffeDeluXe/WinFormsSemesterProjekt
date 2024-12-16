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

namespace WinFormsSemesterProjekt
{
    public partial class Orders : Form
    {
        public BindingList<Order> orderList { get; set; } = new BindingList<Order>();
        public Orders()
        {
            List<Order> listOfOrders = OrderDB.FindAllOrders();

            foreach (Order order in listOfOrders)
            {
                orderList.Add(order);
            }

            InitializeComponent();

            dataGridView1.DataSource = orderList;
        }

        private void searchBar_Leave(object sender, EventArgs e)
        {
            if (orderSearchBar.Text == "")
            {
                orderSearchBar.Text = "Indtast ordrenummer...";
                orderSearchBar.ForeColor = Color.Black;
            }
        }

        private void searchBar_Enter(object sender, EventArgs e)
        {
            if (orderSearchBar.Text == "Indtast ordrenummer...")
            {
                orderSearchBar.Text = "";
                orderSearchBar.ForeColor = Color.LightGray;
            }
        }

        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            OrderTypeSelection orderTypeSelection = new OrderTypeSelection();
            orderTypeSelection.Show();
            this.Hide();
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            ConfirmDeletionOrder confirmDeletionOrder = new ConfirmDeletionOrder();
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
    }
}
