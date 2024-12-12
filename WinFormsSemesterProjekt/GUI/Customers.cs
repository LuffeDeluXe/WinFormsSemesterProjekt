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
        internal List<Customer> CustomerList { get; set; } = CustomerDatabase.RetrieveListOfAllCustomers();
        public Customers()
        {
            InitializeComponent();

            customerView.DataSource = CustomerList;
        }

        private void searchBar_Leave(object sender, EventArgs e)
        {
            if (searchBar.Text == "")
            {
                searchBar.Text = "Søg efter en kunde...";
                searchBar.ForeColor = Color.Black;
            }
        }

        private void searchBar_Enter(object sender, EventArgs e)
        {
            if (searchBar.Text == "Søg efter en kunde...")
            {
                searchBar.Text = "";
                searchBar.ForeColor = Color.LightGray;
            }
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(customerView.CurrentRow.Cells[0].Value.ToString());
            ConfirmDeletionCustomer confirmDeletionCustomer = new ConfirmDeletionCustomer(customerId);
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
            //List <Customer> searchResults = new List <Customer>();
            //int number = 0;
            //if (int.TryParse(searchBar.Text, out number)){
            //    number = int.Parse(searchBar.Text);
            //    Customer idResult = CustomerDatabase.RetrieveASingleCustomersUsingCustomerID(number);
            //    if (Customer.ValidatePhoneNumber) { }
            //    Customer phoneNumberResult = CustomerDatabase.RetrieveASingleCustomersUsingPhoneNumber(number);
                
            //    searchResults.Add(idResult);
            //    searchResults.Add(phoneNumberResult);

            //    customerView.DataSource = searchResults;
            //    customerView.Update();
            //}
            //else
            //{
            //    customerView.DataSource = searchResults;
            //    customerView.Update();
            //}
        }

        private void buttonEditCustomer_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(customerView.CurrentRow.Cells[0].Value.ToString());

            EditCustomer editCustomer = new EditCustomer(customerId);
            editCustomer.Show();
            this.Close();
        }
    }
}
