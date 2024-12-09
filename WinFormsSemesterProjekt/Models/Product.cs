﻿using System;
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
        public double UnitPrice { get; set; }
        public int Stock { get; set; }

		public Product(int productID, string productName, string category, string description, double unitPrice, int stock)
		{
			ProductID = productID;
			ProductName = productName;
			Category = category;
			Description = description;
			UnitPrice = unitPrice;
			Stock = stock;
		}

		public Product(string productName, string category, string description, double unitPrice, int stock)
		{
			ProductID = ProductDatabase.CreateNewProduct(productName, category, description, unitPrice, stock);
			ProductName = productName;
			Category = category;
			Description = description;
			UnitPrice = unitPrice;
			Stock = stock;
		}

	}
}
