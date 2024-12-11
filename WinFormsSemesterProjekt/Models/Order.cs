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
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string OrderStatus { get; set; }
        public double TotalPrice { get; set; }
        public string ShippingMethod { get; set; }

        public Order(int customerID, DateTime orderDate, DateTime deliveryDate, string orderStatus, int totalPrice, string shippingMethod)
        {
            CustomerID = customerID;
            OrderDate = orderDate;
            DeliveryDate = deliveryDate;
            OrderStatus = orderStatus;
            TotalPrice = totalPrice;
            ShippingMethod = shippingMethod;
        }


    }
}
