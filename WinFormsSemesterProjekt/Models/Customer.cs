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

        public Customer (int customerID, string firstName, string lastName, int phoneNumber, string email ,string address)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;

        }

       



        public void UpdateEmail(string newEmail)
        {
            if (newEmail.Contains("@"))
            {
                Email = newEmail;
            }
            else
            {
                Console.WriteLine("Please, enter a valid email");
            }
        }

        public void UpdateFirstName(string newFirstName)
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
