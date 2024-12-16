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
        public string CustomerType { get; private set; }
        public string Area { get; private set; }

        /// <summary>
        /// Use only when reading from database
        /// </summary>
        /// <param name="customerID"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>

        public Customer(int customerID, string firstName, string lastName, int phoneNumber, string email, string customerType, string area)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            CustomerType = customerType;
            Area = area;
        }

        /// <summary>
        /// Use when creating a new Customer, NOT when reading from database. Constructor uploads the customer to the database. 
        /// Creates and then retrieves the correct ID
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        /// <param name="customerType"></param>
        /// <param name="area"></param>
        public Customer(string firstName, string lastName, int phoneNumber, string email, string customerType, string area)
        {
            //CustomerID is created and retrived from databasen using the CreateCustomer Method
            CustomerID = CustomerDatabase.CreateCustomer(firstName, lastName, phoneNumber, email, customerType, area);
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            CustomerType = customerType;
            Area = area;
        }

        /// <summary>
        /// This method has the ability to update one or all parameters of the individual customer information and saves the changes in the database
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        /// <param name="customerType"></param>
        /// <param name="area"></param>
        public static void UpdateWholeCustomer(Customer customer, string firstName, string lastName, int phoneNumber, string email, string customerType, string area)
        {
            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.Email = email;
            customer.CustomerType = customerType;
            customer.Area = area;

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
        public static bool ValidatePhoneNumber(int phoneNumber)
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
