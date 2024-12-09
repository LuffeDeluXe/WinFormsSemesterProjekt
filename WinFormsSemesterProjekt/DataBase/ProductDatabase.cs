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
				"insert into Product (Name, Category, Desription, Price, Stock) " +
				"values (@Name, @Category, @Desription, @Price, @Stock)";

			var command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@Name", product.ProductName);
			command.Parameters.AddWithValue("@Category", product.Category);
			command.Parameters.AddWithValue("@Desription", product.Description);
			command.Parameters.AddWithValue("@Price", product.UnitPrice);
			command.Parameters.AddWithValue("@Stock", product.Stock);

			int productId = DatabaseManager.ExecuteScalar(command);

			return productId;
		}
	}
}
