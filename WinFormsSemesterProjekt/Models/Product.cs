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
        public int MinStock { get; set; }
        public int MaxStock { get; set; }

        public Product(int productID, string productName, string category, string description, double price, int stock, int minStock, int maxStock)
		{
			ProductID = productID;
			ProductName = productName;
			Category = category;
			Description = description;
			Price = price;
			Stock = stock;
			MinStock = minStock;
			MaxStock = maxStock;
		}

		public Product(string productName, string category, string description, double price, int stock, int minStock, int maxStock)
		{
			ProductID = ProductDatabase.CreateNewProduct(productName, category, description, price, stock, minStock, maxStock);
			ProductName = productName;
			Category = category;
			Description = description;
			Price = price;
			Stock = stock;
			MinStock = minStock;
			MaxStock = maxStock;
		}

	}
}
