using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsSemesterprojekt.Models;
using WinFormsSemesterProjekt.DataBase;

namespace WinformsSemesterprojekt
{
    internal class Customer : DatabaseManager
    {
        public int CustomerID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }

        /// <summary>
        /// Use only when reading from database
        /// </summary>
        /// <param name="customerID"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        public Customer (int customerID, string firstName, string lastName, int phoneNumber, string email)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        /// <summary>
        /// Use when creating a new Customer, NOT when reading from database. Constructor uploads the customer to the database. 
        /// Creates and then retrieves the correct ID
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        public Customer(string firstName, string lastName, int phoneNumber, string email)
        {
            //CustomerID is created and retrived from databasen using the CreateCustomer Method
            CustomerID = CustomerDatabase.CreateCustomer(firstName, lastName, phoneNumber, email);
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public static void UpdateWholeCustomer(Customer customer, string firstName, string lastName, int phoneNumber, string email)
        {
            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.PhoneNumber = phoneNumber;
            customer.Email = email;

            CustomerDatabase.UpdateCustomerInformation(customer);
        }
    }
}
