
using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using Enums.Entities.Enum;

namespace Enums.Entities
{
    internal class Order
    {
        public DateTime moment { get; set; }
        public OrderStatus status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> orderItems { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            this.moment = moment;
            this.status = status;
            Client = client;
        }

        public void addItem(OrderItem item)
        {
            orderItems.Add(item);
        }
        
        public void removeItem(OrderItem item)
        {
            orderItems.Remove(item);
        }

        public double total()
        {
            double value = 0;
            foreach (OrderItem item in orderItems)
            {
               value += item.subTotal();
            }
            return value;
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in orderItems)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }


    }
}
