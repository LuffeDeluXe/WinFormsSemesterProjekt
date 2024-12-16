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
        public static int CreateNewOrder(int customerID, DateTime orderDate, DateTime deliveryDate, string orderStatus, double totalPrice, string shippingMethod)
        {
            string query =
                "INSERT INTO [Order] (CustomerID, OrderDate, DeliveryDate, OrderStatus, TotalPrice, ShippingMethod) " +
                "OUTPUT INSERTED.OrderID " +
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
            List<Order> orders = new List<Order>();

            connection.Open();

            string query =
                "SELECT * FROM [Order] " +
                "WHERE OrderID = @OrderID";

            var command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@OrderID", orderID);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var order = new Order(
                    Convert.ToInt32(reader["OrderID"]),
                    Convert.ToInt32(reader["CustomerID"]),
                    Convert.ToDateTime(reader["OrderDate"]),
                    Convert.ToDateTime(reader["DeliveryDate"]),
                    reader["OrderStatus"].ToString(),
                    Convert.ToDouble(reader["TotalPrice"]),
                    reader["ShippingMethod"].ToString());

                orders.Add(order);
            }

            connection.Close();

            return orders[0];
        }

        public static List<Order> FindAllOrders()
        {
            connection.Open();

            List<Order> listOfOrders = new List<Order>();

            string query = "SELECT * FROM [Order]";

            var command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var order = new Order(
                Convert.ToInt32(reader["OrderID"]),
                Convert.ToInt32(reader["CustomerID"]),
                Convert.ToDateTime(reader["OrderDate"]),
                Convert.ToDateTime(reader["DeliveryDate"]),
                reader["OrderStatus"].ToString(),
                Convert.ToDouble(reader["TotalPrice"]),
                reader["ShippingMethod"].ToString());

                listOfOrders.Add(order);
            }

            connection.Close();

            return listOfOrders;
        }

        public static void UpdateOrder(Order order)
        {
            string query =
                "UPDATE [Order] SET " +
                "DeliveryDate = @DeliveryDate " +
                "OrderStatus = @OrderStatus " +
                "TotalPrice = @TotalPrice " +
                "ShippingMethod = @ShippingMethod " +
                "WHERE OrderID = @OrderID";

            var command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DeliveryDate", order.DeliveryDate);
            command.Parameters.AddWithValue("@OrderStatus", order.OrderStatus);
            command.Parameters.AddWithValue("@TotalPrice", order.TotalPrice);
            command.Parameters.AddWithValue("@ShippingMethod", order.ShippingMethod);
            command.Parameters.AddWithValue("@OrderID", order.OrderID);

            DatabaseManager.ExecuteNonQuery(command);
        }

        public static int DeleteOrder(int orderId)
        {
            string query =
                "DELETE [Order] " +
                "WHERE OrderID = @OrderID";

            var command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@OrderID", orderId);

            int rowsAffected = DatabaseManager.ExecuteNonQuery(command);

            return rowsAffected;
        }
    }
}