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

namespace WinFormsSemesterProjekt
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void searchBar_Leave(object sender, EventArgs e)
        {
            if (searchBar.Text == "")
            {
                searchBar.Text = "Indtast ordrenummer...";
                searchBar.ForeColor = Color.Black;
            }
        }

        private void searchBar_Enter(object sender, EventArgs e)
        {
            if (searchBar.Text == "Indtast ordrenummer...")
            {
                searchBar.Text = "";
                searchBar.ForeColor = Color.LightGray;
            }
        }

        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            OrderTypeSelection orderTypeSelection = new OrderTypeSelection();
            orderTypeSelection.Show();
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            ConfirmDeletionOrder confirmDeletionOrder = new ConfirmDeletionOrder();
            confirmDeletionOrder.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                //set GritViewBox bindinglist = FilterByType(radioButton1.Text, currentGritView);
            }
            if (radioButton1.Checked == false)
            {
                // set GritViewBox bindinglist = default;
            }
            //DataGridView.Refresh();
        }

        private void radioButtonFinished_CheckedChanged(object sender, EventArgs e)
        {
            // Missing testing to see what happens first in case of a set checkbox. Which one does thier thing first? the one getting checked or the one getting unchecked?
            if (radioButtonFinished.Checked == true)
            {
                // set GritViewBox bindinglist = FilterByStatus(radioButtonFinished.Text, currentGritViewBox);
            }
            if (radioButtonFinished.Checked == false)
            {
                // set GritViewBox bindinglist = default;
            }
            //DataGridView.Refresh();
        }
        private void radioButtonUnfinished_CheckedChanged(object sender, EventArgs e)
        {
            // Missing testing to see what happens first in case of a set checkbox. Which one does thier thing first? the one getting checked or the one getting unchecked?
            if (radioButtonUnfinished.Checked == true)
            {
                // set GritViewBox bindinglist = FilterByStatus(radioButtonUnfinished.Text, currentGritViewBox);
            }
            if (radioButtonUnfinished.Checked == false)
            {
                // set GritViewBox bindinglist = default;
            }
            //DataGridView.Refresh();
        }


        private static BindingList<Order> FilterByStatus(string OrderStatus, BindingList<Order> orders)
        {
            var filteredList = new List<Order>();
            var inputList = orders.ToList();

            foreach (var order in inputList)
            {
                if (order.OrderStatus == OrderStatus)
                {
                    filteredList.Add(order);
                }
            }
            return new BindingList<Order>(filteredList);
        }

        public static BindingList<Order> FilterByDate(DateTime dateMin, DateTime dateMax, BindingList<Order> orders)
        {
            // Not used yet and UI doesn't support it
            var filteredList = new List<Order>();
            var inputList = orders.ToList();

            foreach (var order in inputList)
            {
                if (order.OrderDate < dateMax && dateMin < order.OrderDate)
                {
                    filteredList.Add(order);
                }
            }
            return new BindingList<Order>(filteredList);
        }

        // We dont have different type of Orders yet, but is now supported
        //public static BindingList<Order> FilterByType(string type, BindingList<Order> orders)
        //{
        //    // Not used yet and UI doesn't support it
        //    var filteredList = new List<Order>();
        //    var inputList = orders.ToList();

        //    foreach (var order in inputList)
        //    {
        //        if (order.type == type)
        //        {
        //            filteredList.Add(order);
        //        }
        //    }
        //    return new BindingList<Order>(filteredList);
        //}
    }
}
