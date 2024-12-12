using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsSemesterProjekt.DataBase;

namespace WinformsSemesterprojekt.Models
{
    public class ProductLine
    {
        public int ProductLineID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public double PricePerUnit { get; set; }

        public ProductLine(int productLineID, int orderID, int productID, int quantity, double pricePerUnit)
        {
            ProductLineID = productLineID;
            OrderID = orderID;
            ProductID = productID;
            Quantity = quantity;
            PricePerUnit = pricePerUnit;
        }

        public ProductLine(int orderID, int productID, int quantity, double pricePerUnit)
        {
            ProductLineID = ProductLineDatabase.UploadToDatabase(orderID, productID, quantity, pricePerUnit);
            OrderID = orderID;
            ProductID = productID;
            Quantity = quantity;
            PricePerUnit = pricePerUnit;
        }

        public void UpdateQuantity(int newQuantity)
        {
            Quantity = newQuantity;
            ProductLineDatabase.UpdateQuantity(ProductLineID, Quantity);
        }
    }
}
