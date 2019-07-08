using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioFixacaoHeranca.Entities;

namespace ExercicioFixacaoHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of product: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Commom, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                switch (type)
                {
                    case 'c':
                        Product p = new Product(name, price);
                        products.Add(p);
                        break;
                    case 'i':
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        p = new ImportedProduct(name, price, customsFee);
                        products.Add(p);
                        break;
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY)");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        p = new UsedProduct(name, price, manufactureDate);
                        products.Add(p);
                        break;
                    default:
                        Console.WriteLine("Tipo inválido.");
                        i--;
                        break;
                }
            }
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
