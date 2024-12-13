using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsSemesterProjekt.DataBase;

namespace WinformsSemesterprojekt.Models
{
    public class Product
    {
        public int ProductID { get; private set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

		public Product(int productID, string productName, string category, string description, double price, int stock)
		{
			ProductID = productID;
			ProductName = productName;
			Category = category;
			Description = description;
			Price = price;
			Stock = stock;
		}

		public Product(string productName, string category, string description, double price, int stock)
		{
			ProductID = ProductDatabase.CreateNewProduct(productName, category, description, price, stock);
			ProductName = productName;
			Category = category;
			Description = description;
			Price = price;
			Stock = stock;
		}

	}
}
