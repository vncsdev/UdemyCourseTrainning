using System;
using OrderSystem.Entities;
using OrderSystem.Entities.Enums;

namespace OrderSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine();

            Order order = new Order(DateTime.Now, status);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double prodPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int prodQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(prodName, prodPrice);
                OrderItem orderItem = new OrderItem(prodQuantity, prodPrice);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine($"Order moment: {order.Moment}");
            Console.WriteLine($"Order status: {order.Status}");
            Console.WriteLine($"Client: {client.Name} ({client.BirthDate.ToString("dd/MM/yyyy")}) - {client.Email}");
            Console.WriteLine();
            Console.WriteLine("ORDER ITEMS:");
            Console.WriteLine(order);
            Console.WriteLine($"Total Price: {order.Total().ToString("C")}");
        }
    }
}
