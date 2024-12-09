using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsSemesterprojekt.Models;

namespace WinFormsSemesterProjekt.DataBase
{
    internal class ProductLineDatabase : DatabaseManager
    {
        public static int UploadToDatabase(int orderID, int productID, int amount)
        {
            SqlCommand command = connection.CreateCommand();
            // Command is inheret from Database.cs as a protected field
            string sql =
                "INSERT INTO ProductLine (OrderID, ProductID, Amount) " +
                "OUTPUT INSERTED.ProductLine.ID " +
                "VALUES (@OrderID, @ProductID, @Amount)";

            command.CommandText = sql;
            command.Parameters.AddWithValue("@OrderID", orderID);
            command.Parameters.AddWithValue("@ProductID", productID);
            command.Parameters.AddWithValue("@Quantity", amount);

            return DatabaseManager.ExecuteScalar(command);
        }

        public static List<ProductLine> LookInTheDatabase(int orderID)
        {
            SqlCommand command = connection.CreateCommand();
            var ProductLineList = new List<ProductLine>();
            command.CommandText =
                "SELECT * from ProductLine WHERE OrderID = @OrderID";
            command.Parameters.AddWithValue("@OrderID", orderID);

            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var productLine = new ProductLine((int)reader[0], 
                                                      (int)reader[1], 
                                                      (int)reader[2]);

                    ProductLineList.Add(productLine);
                }
            }
            return ProductLineList;
        }

        public static List<ProductLine> LookInTheDatabaseProductID(int produktID)
        {
            SqlCommand command = connection.CreateCommand();
            var ProductLineList = new List<ProductLine>();
            command.CommandText =
                "SELECT * from ProductLine WHERE ProduktID = @ProduktID";
            command.Parameters.AddWithValue("@ProduktID", produktID);

            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var productLine = new ProductLine((int)reader[0],
                                                      (int)reader[1],
                                                      (int)reader[2]);

                    ProductLineList.Add(productLine);
                }
            }
            return ProductLineList;
        }

        public static void UpdateAmount(ProductLine productLine, int newQuantity)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText =
                "UPDATE ProductLine SET " +
                "Amount = @Amount, " +
                "WHERE ProductLineID = @ProductLineID";

            command.Parameters.AddWithValue("@Amount", (productLine.Amount + newQuantity));
            command.Parameters.AddWithValue("@Amount", productLine.ProductLineID);

            DatabaseManager.ExecuteNonQuery(command);
        }

        public static bool DeleteProductLine(ProductLine productLine)
        {
            SqlCommand command = connection.CreateCommand();
            string sql =
                "DELETE ProductLine WHERE ProductLineID = @ProductLineID";

            command.CommandText = sql;
            command.Parameters.AddWithValue("@ProductLineID", productLine.ProductLineID);
            int numberOfAffectedRows = DatabaseManager.ExecuteNonQuery(command);

            if (numberOfAffectedRows > 0)
            {
                return true;
            }
            return false;
        }
    }
}
