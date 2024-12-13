using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsSemesterProjekt.DataBase;

namespace WinformsSemesterprojekt.Models
{
    public class Order
    {
        public int OrderID { get; private set; }
        public int CustomerID { get; private set; }
        public DateTime OrderDate { get; private set; }
        public DateTime DeliveryDate { get; private set; }
        public string OrderStatus { get; private set; }
        public double TotalPrice { get; private set; }
        public string ShippingMethod { get; private set; }

        public Order(int customerID, DateTime orderDate, DateTime deliveryDate, string orderStatus, double totalPrice, string shippingMethod)
        {
            CustomerID = customerID;
            OrderDate = orderDate;
            DeliveryDate = deliveryDate;
            OrderStatus = orderStatus;
            TotalPrice = totalPrice;
            ShippingMethod = shippingMethod;
        }

        public Order(int orderID, int customerID, DateTime orderDate, DateTime deliveryDate, string orderStatus, double totalPrice, string shippingMethod)
        {
            OrderID = OrderDB.CreateNewOrder(customerID, orderDate, deliveryDate, orderStatus, totalPrice, shippingMethod);
            CustomerID = customerID;
            OrderDate = orderDate;
            DeliveryDate = deliveryDate;
            OrderStatus = orderStatus;
            TotalPrice = totalPrice;
            ShippingMethod = shippingMethod;
        }

        public static void UpdateWholeOrder(Order order, int customerID, DateTime orderDate, DateTime deliveryDate, string orderStatus, double totalPrice, string shippingMethod)
        {
            order.CustomerID = customerID;
            order.OrderDate = orderDate;
            order.DeliveryDate = deliveryDate;
            order.OrderStatus = orderStatus;
            order.TotalPrice = totalPrice;
            order.ShippingMethod = shippingMethod;

            OrderDB.UpdateOrder(order);
        }
    }
}
