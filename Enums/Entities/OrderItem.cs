using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums.Entities;
using Enums.Entities.Enum;

namespace Enums.Entities
{
    internal class OrderItem
    {

        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }



        public OrderItem(int qtd, double price, Product produto)
        {
            Quantity = qtd;
            Price = price;
            Product = produto;
        }

        public double subTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
