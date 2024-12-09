using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsSemesterprojekt.Models;

namespace WinformsSemesterprojekt
{
    public class Customer
    {
        public int CustomerID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }

        public Customer(int customerID, string firstName, string lastName, string email, int phoneNumber, string address)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public void UpdateEmail(string newEmail)
        {
            Methods methods = new Methods();

            if (newEmail.Contains("@"))
            {
                Email = newEmail;
            }
            else
            {
                methods.PrintText("Please enter a valid email");
            }
        }

        public void UpdateFirstName(string newFirstName)
        {
            Methods methods = new Methods();

            if (newFirstName == "Hitler" || newFirstName == "Putin")
            {
                methods.PrintText("Please enter an appropiate name");
            }
            else
            {
                FirstName = newFirstName;
            }
        }

        public void UpdateLastName(string newLastName)
        {
            Methods methods = new Methods();

            if (newLastName == "Hitler" || newLastName == "Putin")
            {
                methods.PrintText("Please enter an appropiate name");
            }
            else
            {
                LastName = newLastName;
            }
        }

        public void UpdatePhoneNumber(string input)
        {
            Methods methods = new Methods();

            int newPhoneNumber;
            bool result = false;

            result = int.TryParse(input, out newPhoneNumber);

            while (result == false)
            {
                methods.PrintText("Please enter a valid number");
                input = Console.ReadLine();
                result = int.TryParse(input, out newPhoneNumber);
            }

            PhoneNumber = newPhoneNumber;
        }

        public void UpdateAddress(string newAddress)
        {
            Methods methods = new Methods();

            if (newAddress.Contains("Amalienborg Slotsplads"))
            {
                methods.PrintText("Du er ikke Kongen af Danmark >:(");
            }
            else
            {
                Address = newAddress;
            }
        }
    }
}
