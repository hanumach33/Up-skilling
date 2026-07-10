using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise20
{
    class Order
    {
        public int OrderId { get; set; }

        public string CustomerName { get; set; }

        public double TotalAmount { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>
            {
                new Order
                {
                    OrderId = 101,
                    CustomerName = "Alice",
                    TotalAmount = 1500
                },
                new Order
                {
                    OrderId = 102,
                    CustomerName = "Bob",
                    TotalAmount = 750
                },
                new Order
                {
                    OrderId = 103,
                    CustomerName = "Charlie",
                    TotalAmount = 2200
                },
                new Order
                {
                    OrderId = 104,
                    CustomerName = "David",
                    TotalAmount = 950
                },
                new Order
                {
                    OrderId = 105,
                    CustomerName = "Eva",
                    TotalAmount = 1800
                }
            };

            var filteredOrders = orders
                .Where(order => order.TotalAmount > 1000)
                .Select(order => new
                {
                    order.OrderId,
                    order.CustomerName,
                    order.TotalAmount
                });

            Console.WriteLine("Orders with Total Amount Greater Than 1000");

            Console.WriteLine();

            foreach (var order in filteredOrders)
            {
                Console.WriteLine($"Order Id      : {order.OrderId}");
                Console.WriteLine($"Customer Name : {order.CustomerName}");
                Console.WriteLine($"Total Amount  : {order.TotalAmount}");
                Console.WriteLine();
            }
        }
    }
}
