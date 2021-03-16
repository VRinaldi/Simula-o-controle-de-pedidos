using System;
using System.Collections.Generic;
using System.Text;
using Ex.Tent2.Entities.Enums;
using System.Globalization;

namespace Ex.Tent2.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public Client Clients { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, Client client, OrderStatus status)
        {
            Moment = moment;
            Clients = client;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            Item.Add(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem item in Item)
            {
                sum += item.Subtotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Clients);
            sb.AppendLine("Order Items: ");
            foreach(OrderItem item in Item)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
            

        }


    }
}
