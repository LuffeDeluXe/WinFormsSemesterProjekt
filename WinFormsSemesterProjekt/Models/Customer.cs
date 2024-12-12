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
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int PhoneNumber { get; private set; }
        public string Email { get; private set; }

        /// <summary>
        /// Use only when reading from database
        /// </summary>
        /// <param name="customerID"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        public Customer(int customerID, string firstName, string lastName, int phoneNumber, string email)
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

        /// <summary>
        /// This method has the ability to update one or all parameters of the individual customer information and saves the changes in the database
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        public static void UpdateWholeCustomer(Customer customer, string firstName, string lastName, int phoneNumber, string email)
        {
            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.Email = email;

            if (ValidatePhoneNumber(phoneNumber) == true)
            {
                customer.PhoneNumber = phoneNumber;
            }


            CustomerDatabase.UpdateCustomerInformation(customer);
        }


        /// <summary>
        /// Checks if phonenumber is exactly 8 long
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        private static bool ValidatePhoneNumber(int phoneNumber)
        {
            char[] phoneNumberAsACharArr = phoneNumber.ToString().ToCharArray();

            if (phoneNumberAsACharArr.Length != 8)
            {
                return false;
            }

            return true;
        }
    }
}
