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

namespace WinFormsSemesterProjekt.GUI
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
            this.Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int id = 0;
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;

            try
            {
                Convert.ToInt32(textBoxPhoneNumber.Text);
            }
            catch
            {
                InvalidPhoneNumber invalidPhoneNumber = new InvalidPhoneNumber();
                invalidPhoneNumber.Show();
            }

            int phoneNumber = Convert.ToInt32(textBoxPhoneNumber.Text);

            string email = textBoxEmail.Text;

            CreatedCustomer createdCustomer = new CreatedCustomer();
            createdCustomer.Show();
        }
    }
}
