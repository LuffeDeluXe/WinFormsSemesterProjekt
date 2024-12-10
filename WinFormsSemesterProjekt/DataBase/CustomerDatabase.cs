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
        public void CreateCustomer(Customer customer)
        {
            SqlCommand command = connection.CreateCommand();

            string sql =
                "INSERT INTO Customer (FirstName, LastName, PhoneNumber, Email) " +
                "VALUES (@FirstName, @LastName, @PhoneNumber, @Email, )";

            command.CommandText = sql;

            command.Parameters.AddWithValue("@FirstName", customer.FirstName);
            command.Parameters.AddWithValue("@LastName", customer.LastName);
            command.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
            command.Parameters.AddWithValue("@Email", customer.Email);

            DatabaseManager.ExecuteNonQuery(command);
        }
        /*
        /// <summary>
        /// Retrieves a list of all current customers in the database.
        /// </summary>
        /// <param name="CustomerID"></param>
        /// <returns></returns>
        public List<Customer> RetrieveListOfAllCustomers(int CustomerID)
        {
            var customers = new List<Customer>();

            connection.Open();

            // Jeg kan se at både Christinas klasse "Customer" og "DatabaseManager" er sat til public???
            SqlCommand command = connection.CreateCommand
                (
                "SELECT [*] Customer_ID, FirstName, LastName, PhoneNumber, Email" +
                "FROM Customer" +
                "WHERE CustomerID = @CustomerID"
                );
            command.Parameters.AddWithValue("@CustomerID", CustomerID);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                customers.Add(new Customer
                {
                    // Okay, så fordi vores CustomerIDs set er PRIVATE, kan jeg ikke hente det???
                    CustomerID = reader.GetInt32(0), 
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    PhoneNumber = reader.GetInt32(3),
                    Email = reader.GetString(4)
                });
            }
            // Mangler vi ikke en connection.Close();
            return customers;
        }
        */

        /// <summary>
        /// Deletes a customer if given the correct CustomerID of said customer.
        /// </summary>
        /// <param name="customer"></param>
        public void DeleteCustomer(Customer customer)
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
        public void UpdateCustomerInformation(Customer customer)
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
