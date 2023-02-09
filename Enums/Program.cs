using System;
using System.Globalization;
using System.Collections.Generic;
using Enums.Entities;
using Enums.Entities.Enum;

namespace Enums
{
    class Program
    {
        static void Main(string[] arg)
        {



            Console.WriteLine("Enter with the client date");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            string date = Console.ReadLine();
            DateTime d1 = new DateTime();
            d1 = DateTime.Parse(date);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");

            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order o1 = new Order(d1, status);


            Console.Write("How many items to this order? ");
            int qtd = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine("Enter #" + i + " item data:");
                Console.Write("Prodct name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int productQtd = int.Parse(Console.ReadLine());


                //Declaraçao das Classes
                Product p = new Product(productName, productPrice);
                OrderItem item = new OrderItem(productQtd, productPrice ,p);










            }





        }
    }
}