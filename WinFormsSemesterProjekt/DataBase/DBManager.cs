using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsSemesterprojekt.Models;

namespace WinFormsSemesterProjekt.DataBase
{
    internal abstract class DatabaseManager
    {
        protected const string _ConnectionString = "Data Source=localhost;" +
                                  "Initial Catalog=ProProduction;" +
                                  "Integrated Security=SSPI;" +
                                  "TrustServerCertificate=true";

        protected static SqlConnection connection = new SqlConnection(_ConnectionString);


        /// <summary>
        /// Opens, Execute and Close, NonQueries. Returns the number of rows affected by this SQL
        /// </summary>
        /// <param name="command"></param>
        protected static int ExecuteNonQuery(SqlCommand command)
        {
            int numberOfRowsAffected = 0;
            connection.Open();
            numberOfRowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return numberOfRowsAffected;
        }

        /// <summary>
        /// Opens, Execute and returns the ID from Database, and closes when out of scope
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        protected static int ExecuteScalar(SqlCommand command)
        {
            int id = 0;
            connection.Open();
            id = (int)command.ExecuteScalar();
            connection.Close();
            return id;
        }

    }
}
