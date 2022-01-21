using System;
using System.Collections.Generic;
using Products.Entities;

namespace Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine().ToLower());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (ch == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if (ch == 'u')
                {
                    Console.Write("Manufacture date: ");
                    DateTime manuDate = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, manuDate));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());

                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                Console.WriteLine();
            }

            Console.WriteLine("PRICE TAGS:");

            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
