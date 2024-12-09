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
        public int CustomerID { get; private set; }
        public DateTime OrderDate { get; private set; }


        public Order(int orderID, int productLineID, int customerID, DateTime orderDate)
        {
            OrderID = orderID;
            CustomerID = customerID;
            OrderDate = orderDate;
        }
    }
}
