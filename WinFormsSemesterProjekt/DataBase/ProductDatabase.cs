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
		public static int CreateNewProduct(string productName, string category, string description, double unitPrice, int stock)
		{
			string query =
				"INSERT INTO Product (Name, Category, Desription, Price, Stock) " +
				"VALUES (@Name, @Category, @Desription, @Price, @Stock)";

			var command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@Name", productName);
			command.Parameters.AddWithValue("@Category", category);
			command.Parameters.AddWithValue("@Desription", description);
			command.Parameters.AddWithValue("@Price", unitPrice);
			command.Parameters.AddWithValue("@Stock", stock);

			int productId = DatabaseManager.ExecuteScalar(command);

			return productId;
		}

		public static Product FindProduct(int productID)
		{
			string query = "SELECT * FROM Product " +
						   "WHERE ProductID = @ProductID";

			var command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@ProductID", productID);

			SqlDataReader reader = command.ExecuteReader();

			var product = new Product(
			Convert.ToInt32(reader["ProductID"]),
			reader["Name"].ToString(),
			reader["Category"].ToString(),
			reader["Desription"].ToString(),
			Convert.ToInt32(reader["Price"]),
			Convert.ToInt32(reader["Stock"])
			);

			connection.Close();

			return product;
		}

		public static List<Product> FindAllProducts()
		{
			List<Product> listOfProducts = new List<Product>();
			
			string query = "SELECT * FROM Product";

			var command = new SqlCommand(query, connection);

			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				var product = new Product(
				Convert.ToInt32(reader["ProductID"]),
				reader["Name"].ToString(),
				reader["Category"].ToString(),
				reader["Desription"].ToString(),
				Convert.ToInt32(reader["Price"]),
				Convert.ToInt32(reader["Stock"])
				);
				listOfProducts.Add(product);
			}

			connection.Close();

			return listOfProducts;
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
				reader["Desription"].ToString(),
				Convert.ToInt32(reader["Price"]),
				Convert.ToInt32(reader["Stock"])
				);
				listOfCategoryProducts.Add(product);
			}

			return listOfCategoryProducts;
		}

		public static void UpdateProduct(Product product, string name, string category, string desription, int unitPrice, int stock)
		{
			string query = "UPDATE Product " +
						   "SET Name = @Name " +
						   "Category = @Category " +
						   "Desription = @Desription " +
						   "Price = @Price " +
						   "Stock = @Stock " +
						   "WHERE ProductID = @ProductID";

			var command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@ProductID", product.ProductID);
			command.Parameters.AddWithValue("@Name", name);
			command.Parameters.AddWithValue("@Category", category);
			command.Parameters.AddWithValue("@Desription", desription);
			command.Parameters.AddWithValue("@Price", unitPrice);
			command.Parameters.AddWithValue("@Stock", stock);

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
