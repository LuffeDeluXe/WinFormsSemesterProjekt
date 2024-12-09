using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsSemesterprojekt.Models
{
    public class Order
    {
        public int OrderID { get; private set; }
        public int ProductLineID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }

        public Order(int orderID, int productLineID, int customerID, DateTime orderDate)
        {
            OrderID = orderID;
            ProductLineID = productLineID;
            CustomerID = customerID;
            OrderDate = orderDate;
        }
    }
}
