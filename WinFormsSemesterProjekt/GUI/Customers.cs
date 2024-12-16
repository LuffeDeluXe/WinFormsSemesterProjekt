using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsSemesterprojekt;
using WinFormsSemesterProjekt.GUI;
using WinFormsSemesterProjekt.GUI.PopUps;
using WinFormsSemesterProjekt.DataBase;

namespace WinFormsSemesterProjekt
{
    public partial class Customers : Form
    {
        internal BindingList<Customer> BindingCustomerList = new BindingList<Customer>(CustomerDatabase.RetrieveListOfAllCustomers());
        public Customers()
        {
            InitializeComponent();

            customerView.DataSource = BindingCustomerList;
            listBoxAreas.DataSource = CustomerDatabase.GetAreas();
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(customerView.CurrentRow.Cells[0].Value.ToString());
            ConfirmDeletionCustomer confirmDeletionCustomer = new ConfirmDeletionCustomer(customerId, BindingCustomerList);
            confirmDeletionCustomer.Show();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Hide();
        }

        private void buttonNewCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
            this.Hide();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<Customer> searchResults = new List<Customer>();
            int number = 0;
            if (int.TryParse(searchBar.Text, out number))
            {
                number = int.Parse(searchBar.Text);
                bool noMatchById = false;
                bool noMatchByPhoneNumber = false;

                try
                {
                    Customer idResult = CustomerDatabase.RetrieveASingleCustomersUsingCustomerID(number);
                    searchResults.Add(idResult);
                }
                catch
                {
                    noMatchById = true;
                }

                try
                {
                    Customer phoneNumberResult = CustomerDatabase.RetrieveASingleCustomersUsingPhoneNumber(number);
                    searchResults.Add(phoneNumberResult);
                }
                catch
                {
                    noMatchByPhoneNumber = true;
                }

                customerView.DataSource = searchResults;
                customerView.Update();
            }
            else
            {
                customerView.DataSource = searchResults;
                customerView.Update();
            }
            if (searchBar.Text == "")
            {
                customerView.DataSource = BindingCustomerList;
                customerView.Update();
            }
        }

        private void buttonEditCustomer_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(customerView.CurrentRow.Cells[0].Value.ToString());

            EditCustomer editCustomer = new EditCustomer(customerId);
            editCustomer.Show();
            this.Close();
        }

        private void listBoxAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAreas.GetItemText(listBoxAreas.SelectedItem) != "Alle områder")
            {
                List<Customer> customerChecker = CustomerDatabase.RetrieveCustomersByArea(listBoxAreas.GetItemText(listBoxAreas.SelectedItem));
                
                customerView.DataSource = GUICustomersMethods.FilterByType(customerChecker, this);
                customerView.Update();
            }
            else if (listBoxAreas.GetItemText(listBoxAreas.SelectedItem) == "Alle områder")
            {
                var convertToList = new List<Customer>(BindingCustomerList);
                customerView.DataSource = GUICustomersMethods.FilterByType(convertToList, this);
                customerView.Update();
            }
        }

        private void radioButtonPrivateCustomer_Click(object sender, EventArgs e)
        {
            if (listBoxAreas.GetItemText(listBoxAreas.SelectedItem) != "Alle områder")
            {
                List<Customer> customerChecker = CustomerDatabase.RetrieveCustomersByArea(listBoxAreas.GetItemText(listBoxAreas.SelectedItem));

                customerView.DataSource = GUICustomersMethods.FilterByType(customerChecker, this);
                customerView.Update();
            }
            else
            {
                customerView.DataSource = CustomerDatabase.RetrieveCustomersByType("Privatkunde");
                customerView.Update();
            }
        }

        private void radioButtonCompany_Click(object sender, EventArgs e)
        {
            if (listBoxAreas.GetItemText(listBoxAreas.SelectedItem) != "Alle områder")
            {
                List<Customer> customerChecker = CustomerDatabase.RetrieveCustomersByArea(listBoxAreas.GetItemText(listBoxAreas.SelectedItem));

                customerView.DataSource = GUICustomersMethods.FilterByType(customerChecker, this);
                customerView.Update();
            }
            else
            {
                customerView.DataSource = CustomerDatabase.RetrieveCustomersByType("Erhvervskunde");
                customerView.Update();
            }
        }
    }
}
