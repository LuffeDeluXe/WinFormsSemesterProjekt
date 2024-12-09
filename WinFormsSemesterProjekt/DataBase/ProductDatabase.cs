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
		public int CreateNewProduct(Product product)
		{
			string query =
				"INSERT INTO Product (Name, Category, Desription, Price, Stock) " +
				"VALUES (@Name, @Category, @Desription, @Price, @Stock)";

			var command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@Name", product.ProductName);
			command.Parameters.AddWithValue("@Category", product.Category);
			command.Parameters.AddWithValue("@Desription", product.Description);
			command.Parameters.AddWithValue("@Price", product.UnitPrice);
			command.Parameters.AddWithValue("@Stock", product.Stock);

			int productId = DatabaseManager.ExecuteScalar(command);

			return productId;
		}

		public Product FindProduct(int productID)
		{
			string query = "SELECT * FROM Product " +
						   "WHERE ProductID = @ProductID";

			var command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@ProductID", productID);

			SqlDataReader reader = command.ExecuteReader();

			var product = new Product(
			reader["Name"].ToString(),
			reader["Category"].ToString(),
			reader["Desription"].ToString(),
			Convert.ToInt32(reader["Price"]),
			Convert.ToInt32(reader["Stock"])
			);

			return product;
		}

		public List<Product> FindAllProducts()
		{
			List<Product> products = new List<Product>();
			
			string query = "SELECT * FROM Product";

			var command = new SqlCommand(query, connection);

			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				var product = new Product(
				reader["Name"].ToString(),
				reader["Category"].ToString(),
				reader["Desription"].ToString(),
				Convert.ToInt32(reader["Price"]),
				Convert.ToInt32(reader["Stock"])
				);
				products.Add(product);
			}

			return products;
		}

		public void UpdateProduct(Product product)
		{
			string query = "UPDATE Product SET " +
						   "Name = @Name" +
						   "Category = @Category" +
						   "Desription = @Desription" +
						   "Price = @Price" +
						   "Stock = @Stock";

			var command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@Name", product.ProductName);
			command.Parameters.AddWithValue("@Category", product.Category);
			command.Parameters.AddWithValue("@Desription", product.Description);
			command.Parameters.AddWithValue("@Price", product.UnitPrice);
			command.Parameters.AddWithValue("@Stock", product.Stock);

			DatabaseManager.ExecuteNonQuery(command);
		}

		public int DeleteProduct(int productID) 
		{
			string query = "DELETE Product WHERE ProductID = @ProductID";

			var command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@ProductID", productID);

			int rowsAffected = DatabaseManager.ExecuteNonQuery(command);

			return rowsAffected;
		}
	}
}
