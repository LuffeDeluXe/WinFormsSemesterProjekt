using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsSemesterprojekt.Models
{
    public class ProductLine
    {
        public int ProductLineID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Amount { get; set; }

        public ProductLine(int orderID, int productID, int amount)
        {
            OrderID = orderID;
            ProductID = productID;
            Amount = amount;
        }
    }
}
