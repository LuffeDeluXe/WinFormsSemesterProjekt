using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsSemesterprojekt.Models
{
    public class Product
    {
        public int ProductID { get; private set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int InStock { get; set; }

        public Product(int productID, string productName, int unitPrice, int inStock)
        {
            ProductID = productID;
            ProductName = productName;
            UnitPrice = unitPrice;
            InStock = inStock;
        }

        public void UpdatePrice(string input)
        {
            Methods methods = new Methods();

            double newPrice;
            bool result = false;

            result = double.TryParse(input, out newPrice);

            while (result == false)
            {
                methods.PrintText("Please enter a valid number");
                input = Console.ReadLine();
                result = double.TryParse(input, out newPrice);
            }

            UnitPrice = newPrice;
        }

        public void UpdateStock(string input)
        {
            Methods methods = new Methods();

            int newStock;
            bool result = false;

            result = int.TryParse(input, out newStock);

            while (result == false)
            {
                methods.PrintText("Please enter a valid number");
                input = Console.ReadLine();
                result = int.TryParse(input, out newStock);
            }
            InStock = newStock;
        }
    }
}
