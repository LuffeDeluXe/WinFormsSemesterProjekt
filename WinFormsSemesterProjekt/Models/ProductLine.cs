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
        public int ProductLineID { get; private set; }
        public int OrderID { get; private set; }
        public int ProductID { get; private set; }
        public int Quantity { get; private set; }
        public double PricePerUnit { get; private set; }

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

        public static void UpdateQuantity(int productLineID, int newQuantity)
        {
            ProductLineDatabase.UpdateQuantity(productLineID, newQuantity);
        }
    }
}