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

        public static void UpdateCustomerEmail(Customer customer, string newEmail)
        {
            if (newEmail.Contains("@"))
            {
                customer.Email = newEmail;
                CustomerDatabase.UpdateCustomerInformation(customer);
            }
        }

        public static void UpdateCustomerFirstName(string newFirstName)
        {
            if (newFirstName == "Hitler" || newFirstName == "Putin")
            {
                Console.WriteLine("Please, enter an appropiate name");
            }
            else
            {
                FirstName = newFirstName;
            }
        }

        public void UpdateLastName(string newLastName)
        {
            if (newLastName == "Hitler" || newLastName == "Putin")
            {
                Console.WriteLine("Please, enter an appropiate name");
            }
            else
            {
                LastName = newLastName;
            }
        }
        /*
        public void UpdatePhoneNumber(string input)
        {
            int newPhoneNumber;
            bool result = false;

            result = int.TryParse(input, out newPhoneNumber);

            while (result == false)
            {
                Console.WriteLine("Please, enter a valid number");
                input = Console.ReadLine();
                result = int.TryParse(input, out newPhoneNumber);
            }

            PhoneNumber = newPhoneNumber;
        }
        */

        /*
        public void UpdateAddress(string newAddress)
        {
            if (newAddress.Contains("Amalienborg Slotsplads"))
            {
                Console.WriteLine("Du er ikke Kongen af Danmark >:(");
            }
            else
            {
                Address = newAddress;
            }
        }
        */
    }
}
