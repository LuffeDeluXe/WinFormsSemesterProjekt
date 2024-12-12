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
using WinFormsSemesterProjekt.GUI.PopUps;
using WinformsSemesterprojekt.Models;
using WinFormsSemesterProjekt.DataBase;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsSemesterProjekt.GUI
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        InvalidPhoneNumber invalidPhoneNumber = new InvalidPhoneNumber();
        InvalidCustomerType invalidCustomerType = new InvalidCustomerType();

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
            this.Hide();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!radioButtonPrivateCustomer.Checked && !radioButtonCompany.Checked)
            {
                invalidCustomerType.Show();
            }
            else
            {

                int phoneNumber = 0;
                if (int.TryParse(textBoxPhoneNumber.Text, out phoneNumber) == false)
                {
                    invalidPhoneNumber.Show();
                }
                else if (textBoxPhoneNumber.Text == "")
                {
                    invalidPhoneNumber.Show();
                }
                else
                {
                    phoneNumber = Convert.ToInt32(textBoxPhoneNumber.Text);
                }

                if (Customer.ValidatePhoneNumber(phoneNumber) == false)
                {
                    invalidPhoneNumber.Show();
                }
                else
                {

                    string firstName = textBoxFirstName.Text;
                    string lastName = textBoxLastName.Text;
                    string email = textBoxEmail.Text;
                    string area = textBoxArea.Text;
                    string customerType = "";

                    if (radioButtonPrivateCustomer.Checked)
                    {
                        customerType = "Privatkunde";
                    }
                    if (radioButtonCompany.Checked)
                    {
                        customerType = "Erhvervskunde";
                    }

                    Customer newCustomer = new Customer(firstName, lastName, phoneNumber, email, customerType, area);

                    string customerName = firstName + " " + lastName;

                    CreatedCustomer createdCustomer = new CreatedCustomer(customerName);
                    createdCustomer.Show();
                }
            }
        }
    }
}
