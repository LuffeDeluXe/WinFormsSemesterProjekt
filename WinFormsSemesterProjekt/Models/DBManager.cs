using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsSemesterprojekt.Models
{
    public class DatabaseManager
    {
        string connectionString = "Data Source=localhost;" +
                                  "Initial Catalog=ProProduction;" +
                                  "Integrated Security=SSPI;" +
                                  "TrustServerCertificate=true";

        public int AddProduct(Product product)
        {
            using var connection = new SqlConnection(connectionString);

            return 0;
        }
    }
}
