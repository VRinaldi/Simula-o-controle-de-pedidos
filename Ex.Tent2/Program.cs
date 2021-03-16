using System;
using System.Globalization;
using Ex.Tent2.Entities;
using Ex.Tent2.Entities.Enums;

namespace Ex.Tent2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthdate);
            Console.WriteLine();
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus orderstatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, client, orderstatus);

            Console.Write("How many items to this order: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} data:");
                Console.Write("Name: ");
                string pname = Console.ReadLine();
                Console.Write("Price: ");
                double pprice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(pname, pprice);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem item = new OrderItem(product, quantity);

                order.AddItem(item);
                Console.WriteLine();
            }

            Console.WriteLine("Order Summary: ");
            Console.WriteLine(order);
        }
    }
}
