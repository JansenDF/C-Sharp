using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixaçãoAula122.Entities
{
    class OrderItem
    {
        public Product NameProduct { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(Product nameProduct , int quantity, double price)
        {
            NameProduct = nameProduct;
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }
    }
}
