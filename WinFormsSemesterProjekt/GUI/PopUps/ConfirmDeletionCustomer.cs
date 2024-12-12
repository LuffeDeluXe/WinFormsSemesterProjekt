﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsSemesterprojekt;
using WinFormsSemesterProjekt.DataBase;

namespace WinFormsSemesterProjekt.GUI.PopUps
{
    public partial class ConfirmDeletionCustomer : Form
    {
        private readonly Customer _customerInDeletion = new Customer(0, "", "", 0, "", "", "");
        private readonly BindingList<Customer> _customersList = new BindingList<Customer>();
        internal ConfirmDeletionCustomer(int customerId, BindingList<Customer> list)
        {
            InitializeComponent();
            _customerInDeletion = CustomerDatabase.RetrieveASingleCustomersUsingCustomerID(customerId);
            labelText.Text = $"Er du sikker på, at du vil slette {_customerInDeletion.FirstName} + {_customerInDeletion.LastName}?";

            _customersList = list;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            CustomerDatabase.DeleteCustomer(_customerInDeletion);
            int customerId = _customerInDeletion.CustomerID;
            this.Close();
            GUICustomersMethods.DeleteCustomer(_customersList, customerId);
            DeletedCustomer deletedCustomer = new DeletedCustomer();
            deletedCustomer.Show();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
