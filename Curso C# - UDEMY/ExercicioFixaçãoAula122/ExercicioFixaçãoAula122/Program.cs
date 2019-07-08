using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioFixaçãoAula122.Entities;
using ExercicioFixaçãoAula122.Enums;

namespace ExercicioFixaçãoAula122
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string nameCliente = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());

            Client c = new Client(nameCliente, email, birthDay);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, c);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product p = new Product(nameProduct, price);
                OrderItem o = new OrderItem(p, quantity, price);

                order.AddItem(o);
            }
            Console.WriteLine();
            Console.WriteLine(order);

        }
    }
}
