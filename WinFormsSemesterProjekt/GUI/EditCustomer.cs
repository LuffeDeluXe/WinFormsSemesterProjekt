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
using WinFormsSemesterProjekt.DataBase;

namespace WinFormsSemesterProjekt.GUI
{
    public partial class EditCustomer : Form
    {
        private Customer _editCustomer {get;set;}
        public EditCustomer(int customerId)
        {
            InitializeComponent();
            _editCustomer = CustomerDatabase.RetrieveASingleCustomersUsingCustomerID(customerId);

            textBoxFirstName.Text = _editCustomer.FirstName;
            textBoxLastName.Text = _editCustomer.LastName;
            textBoxPhoneNumber.Text = _editCustomer.PhoneNumber.ToString();
            textBoxEmail.Text = _editCustomer.Email;
            textBoxArea.Text = _editCustomer.Area;
            if (_editCustomer.CustomerType == "Privatkunde")
            {
                radioButtonPrivateCustomer.Checked = true;
            }
            else if (_editCustomer.CustomerType == "Erhvervskunde")
            {
                radioButtonCompany.Checked = true;
            }
        }

        InvalidPhoneNumber invalidPhoneNumber = new InvalidPhoneNumber();

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
            this.Hide();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
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

                Customer.UpdateWholeCustomer(_editCustomer, firstName, lastName, phoneNumber, email, customerType, area);

                string customerName = firstName + " " + lastName;
                UpdatedCustomer updatedCustomer = new UpdatedCustomer(customerName);
                updatedCustomer.Show();
            }
        }
    }
}
