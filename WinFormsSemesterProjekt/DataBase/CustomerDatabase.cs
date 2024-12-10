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
        /// Creates a customer in the database.
        /// </summary>
        /// <param name="customer"></param>
        public static int CreateCustomer(string firstName, string lastName, int phoneNumber, string email)
        {
            SqlCommand command = connection.CreateCommand();

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

        /// <summary>
        /// Retrieves a list of all current customers in the database.
        /// </summary>
        /// <param name="CustomerID"></param>
        /// <returns></returns>
        public static Customer RetrieveASingleCustomers(int CustomerID)
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
            // Mangler vi ikke en connection.Close();
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

            //Forklar mig lige numberOfAffectedRows > 0???
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
