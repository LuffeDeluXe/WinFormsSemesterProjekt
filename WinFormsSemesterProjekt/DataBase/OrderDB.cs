using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsSemesterprojekt.Models;

namespace WinFormsSemesterProjekt.DataBase
{
    internal class OrderDB : DatabaseManager
    {
        public static int CreateNewOrder(int customerID, double totalPrice, DateTime deliveryDate, string orderStatus, DateTime orderDate, string shippingMethod)
        {
            string query =
                "INSERT INTO Order (CustomerID, OrderDate, DeliveryDate, OrderStatus, TotalPrice, ShippingMethod)" +
                "VALUES (@CustomerID, @OrderDate, @DeliveryDate, @OrderStatus, @TotalPrice, @ShippingMethod)";

            var command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CustomerID", customerID);
            command.Parameters.AddWithValue("@OrderDate", orderDate);
            command.Parameters.AddWithValue("@DeliveryDate", deliveryDate);
            command.Parameters.AddWithValue("@OrderStatus", orderStatus);
            command.Parameters.AddWithValue("@TotalPrice", totalPrice);
            command.Parameters.AddWithValue("@ShippingMethod", shippingMethod);

            int orderId = DatabaseManager.ExecuteScalar(command);

            return orderId;
        }

        public static Order FindOrder(int orderID)
        {
            string query =
                "SELECT * FROM Order" +
                "WHERE OrderID = @OrderID";

            var command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@OrderID", orderID);

            SqlDataReader reader = command.ExecuteReader();

            var order = new Order(
                Convert.ToInt32(reader["CustomerID"]),
                Convert.ToDateTime(reader["OrderDate"]).ToString("dd/MM/yyyy"),
                Convert.ToDateTime(reader["DeliveryDate"]).ToString("dd/MM/yyyy"),
                reader["OrderStatus"].ToString(),
                Convert.ToInt32(reader["TotalPrice"]),
                reader[""].ToString);

        }
    }
}
