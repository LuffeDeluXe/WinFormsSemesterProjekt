using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsSemesterprojekt;

namespace WinFormsSemesterProjekt.DataBase
{
    internal class CustomerDatabase : DatabaseManager
    {
        /// <summary>
        /// Creates a customer in only database and returns the ID on inserted Customer
        /// </summary>
        /// <param name="customer"></param>
        public static int CreateCustomer(string firstName, string lastName, int phoneNumber, string email)
        {
            SqlCommand command = connection.CreateCommand();

            // OUTPUT Inserted.CustomerID just means that the database will return a output which in this case would be CustomerID using the ExecuteScalar method
            string sql =
                "INSERT INTO Customer (FirstName, LastName, PhoneNumber, Email) " +
                "OUTPUT INSERTED.CustomerID " +
                "VALUES (@FirstName, @LastName, @PhoneNumber, @Email)";

            command.CommandText = sql;

            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            command.Parameters.AddWithValue("@Email", email);

            return DatabaseManager.ExecuteScalar(command);
        }

        public static Customer RetrieveASingleCustomersUsingCustomerID(int CustomerID)
        {
            var customers = new List<Customer>();

            connection.Open();

            SqlCommand command = connection.CreateCommand();

            string sql =
                (
                "SELECT * FROM Customer" +
                "WHERE CustomerID = @CustomerID"
                );

            command.CommandText = sql;
            command.Parameters.AddWithValue("@CustomerID", CustomerID);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var ReadCustomer = new Customer(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4));
            }
            connection.Close();

            return customers[0];
        }
      
        public static Customer RetrieveASingleCustomersUsingPhoneNumber(int phoneNumber)
        {
            var customers = new List<Customer>();

            connection.Open();

            SqlCommand command = connection.CreateCommand();

            string sql =
                (
                "SELECT * FROM Customer" +
                "WHERE PhoneNumber = @PhoneNumber"
                );

            command.CommandText = sql;
            command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {

                var ReadCustomer = new Customer(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4));

            }

            connection.Close();

            return customers[0];
        }

        public static List<Customer> RetrieveListOfAllCustomers()
        {
            var customers = new List<Customer>();

            SqlCommand command = connection.CreateCommand();

            string sql =
                (
                "SELECT * FROM Customer" 
                );

            command.CommandText = sql;

            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var ReadCustomer = new Customer(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4));
                customers.Add(ReadCustomer);
            }

            connection.Close();

            return customers;
        }

        /// <summary>
        /// Deletes a customer if given the correct CustomerID of said customer.
        /// </summary>
        /// <param name="customer"></param>
        public static void DeleteCustomer(Customer customer)
        {
            SqlCommand command = connection.CreateCommand();

            string sql =
                "DELETE Customer" +
                "WHERE CustomerID = @CustomerID";

            command.CommandText = sql;
            command.Parameters.AddWithValue("@CustomerID", customer.CustomerID);

            DatabaseManager.ExecuteNonQuery(command);
        }

        /// <summary>
        /// This method has the ability to update one or all parameters of the individual customer information.
        /// </summary>
        /// <param name="customer"></param>
        public static void UpdateCustomerInformation(Customer customer)
        {
            SqlCommand command = connection.CreateCommand();

            string sql =
                "UPDATE Customer" +
                "SET (FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, Email = @Email)" +
                "WHERE CustomerID = @CustomerID";

            command.CommandText = sql;

            command.Parameters.AddWithValue("@FirstName", customer.FirstName);
            command.Parameters.AddWithValue("@LastName", customer.LastName);
            command.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
            command.Parameters.AddWithValue("@Email", customer.Email);

            DatabaseManager.ExecuteNonQuery(command);
        }
    }
}
