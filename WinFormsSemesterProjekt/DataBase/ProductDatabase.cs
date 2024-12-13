using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsSemesterprojekt.Models;

namespace WinFormsSemesterProjekt.DataBase
{
	internal class ProductDatabase : DatabaseManager
	{
		public static int CreateNewProduct(string productName, string category, string description, double price, int stock, int minStock, int maxStock)
		{
			string query =
				"INSERT INTO Product (Name, Category, Description, Price, Stock, MinStock, MaxStock) " +
				"OUTPUT INSERTED.ProductID " +
				"VALUES (@Name, @Category, @Description, @Price, @Stock, @MinStock, @MaxStock)";

			var command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@Name", productName);
			command.Parameters.AddWithValue("@Category", category);
			command.Parameters.AddWithValue("@Description", description);
			command.Parameters.AddWithValue("@Price", price);
			command.Parameters.AddWithValue("@Stock", stock);
			command.Parameters.AddWithValue("@MinStock", minStock);
			command.Parameters.AddWithValue("@MaxStock", maxStock);

			int productId = DatabaseManager.ExecuteScalar(command);

			return productId;
		}

		public static Product FindProduct(int productID)
		{
			List<Product> listOfProducts = new List<Product>();

			string query = "SELECT * FROM Product " +
						   "WHERE ProductID = @ProductID";

			var command = new SqlCommand(query, connection);

			connection.Open();

			command.Parameters.AddWithValue("@ProductID", productID);

			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				var product = new Product(
				Convert.ToInt32(reader["ProductID"]),
				reader["Name"].ToString(),
				reader["Category"].ToString(),
				reader["Description"].ToString(),
				Convert.ToDouble(reader["Price"]),
				Convert.ToInt32(reader["Stock"]),
                Convert.ToInt32(reader["MinStock"]),
                Convert.ToInt32(reader["MaxStock"])
                );
				listOfProducts.Add(product);
			}

			connection.Close();

			return listOfProducts[0];
		}

		public static List<Product> FindAllProducts()
		{
			List<Product> listOfProducts = new List<Product>();

			string query = "SELECT * FROM Product";

			var command = new SqlCommand(query, connection);

			connection.Open();

			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				var product = new Product(
				Convert.ToInt32(reader["ProductID"]),
				reader["Name"].ToString(),
				reader["Category"].ToString(),
				reader["Description"].ToString(),
				Convert.ToDouble(reader["Price"]),
				Convert.ToInt32(reader["Stock"]),
                Convert.ToInt32(reader["MinStock"]),
                Convert.ToInt32(reader["MaxStock"])
                );
				listOfProducts.Add(product);
			}

			connection.Close();

			return listOfProducts;
		}

        public static List<Product> FindProductsByName(string name)
        {
            List<Product> nameMatches = new List<Product>();

            string query = "SELECT * FROM Product " +
						   "WHERE Name = @Name";

            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", name);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var product = new Product(
                Convert.ToInt32(reader["ProductID"]),
                reader["Name"].ToString(),
                reader["Category"].ToString(),
                reader["Description"].ToString(),
                Convert.ToDouble(reader["Price"]),
                Convert.ToInt32(reader["Stock"]),
                Convert.ToInt32(reader["MinStock"]),
                Convert.ToInt32(reader["MaxStock"])
                );
                nameMatches.Add(product);
            }

            connection.Close();

            return nameMatches;
        }

        public static List<Product> SortProductsByCategory(string category)
		{
			var listOfCategoryProducts = new List<Product>();

			string query = "SELECT * FROM Product " +
						   "WHERE Category = @Category";

			var command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@Category", category);

			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				var product = new Product(
				Convert.ToInt32(reader["ProductID"]),
				reader["Name"].ToString(),
				reader["Category"].ToString(),
				reader["Description"].ToString(),
				Convert.ToDouble(reader["Price"]),
				Convert.ToInt32(reader["Stock"]),
                Convert.ToInt32(reader["MinStock"]),
                Convert.ToInt32(reader["MaxStock"])
                );
				listOfCategoryProducts.Add(product);
			}

			return listOfCategoryProducts;
		}

		public static void UpdateProduct(int id, string name, string category, string desription, double price, int stock, int minStock, int maxStock)
		{
			string query = "UPDATE Product " +
						   "SET Name = @Name, " +
						   "Category = @Category, " +
						   "Description = @Description, " +
						   "Price = @Price, " +
						   "Stock = @Stock " +
						   "MinStock = @MinStock " +
						   "MaxStock = @MaxStock " +
						   "WHERE ProductID = @ProductID";

			var command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@ProductID", id);
			command.Parameters.AddWithValue("@Name", name);
			command.Parameters.AddWithValue("@Category", category);
			command.Parameters.AddWithValue("@Description", desription);
			command.Parameters.AddWithValue("@Price", price);
			command.Parameters.AddWithValue("@Stock", stock);
            command.Parameters.AddWithValue("@MinStock", minStock);
            command.Parameters.AddWithValue("@MaxStock", maxStock);


            DatabaseManager.ExecuteNonQuery(command);
		}

		public static int DeleteProduct(int productID)
		{
			string query = "DELETE Product WHERE ProductID = @ProductID";

			var command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@ProductID", productID);

			int rowsAffected = DatabaseManager.ExecuteNonQuery(command);

			return rowsAffected;
		}
	}
}
