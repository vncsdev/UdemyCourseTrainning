using System;
using System.Collections.Generic;
using TaxPayer.Entities;

namespace TaxPayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayerClass> list = new List<TaxPayerClass>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");

                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpeditures = double.Parse(Console.ReadLine());

                    list.Add(new Individual(name, annualIncome, healthExpeditures));
                }
                else if (ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, annualIncome, numberEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayerClass t in list)
            {
                Console.WriteLine($"{t.Name}: {t.Tax().ToString("C")}");
            }

            double sum = 0;
            foreach (TaxPayerClass t in list)
            {
                sum += t.Tax();
            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: {sum.ToString("C")}");

        }
    }
}
