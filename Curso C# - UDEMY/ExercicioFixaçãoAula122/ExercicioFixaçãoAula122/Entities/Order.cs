using System;
using System.Globalization;
using ExercicioFixaçãoAula122.Enums;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixaçãoAula122.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
            Items = new List<OrderItem>();
        }

        public void AddItem(OrderItem items)
        {
            Items.Add(items);
        }
        public void RemoveItem(OrderItem items)
        {
            Items.Remove(items);
        }
        public double Total()
        {
            double sum=0.0;
            foreach(OrderItem tot in Items)
            {
                sum += tot.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine($"Order moment: {Moment}");
            Console.WriteLine($"Order status: {Status}");
            Console.WriteLine($"Client: {Client.NameClient} ({Client.BirthDate}) - {Client.Email}");
            Console.WriteLine($"Order items:");
            foreach (OrderItem items in Items)
            {
                Console.WriteLine($"{items.NameProduct.NameProduct}, ${items.Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {items.Quantity}, Subtotal: {items.SubTotal().ToString("F2",CultureInfo.InvariantCulture)}");
            }
            return $"Total price: {Total().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
