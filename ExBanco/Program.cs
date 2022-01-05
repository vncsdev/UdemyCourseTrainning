using System;

namespace ExBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banco b;

            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n): ");
            char resp = char.Parse(Console.ReadLine().ToLower());

            if (resp == 's')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double DepInicial = double.Parse(Console.ReadLine());

                b = new Banco(conta, titular, DepInicial);
            }
            else
            {
                b = new Banco(conta, titular);
            }

            Console.WriteLine();
            Console.WriteLine($"DADOS DA CONTA: \n{b}");

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            b.Deposito(double.Parse(Console.ReadLine()));
            
            Console.WriteLine();
            Console.WriteLine($"VALORES ATUALIZADOS: \n{b}");

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            b.Saque(double.Parse(Console.ReadLine()));           

            Console.WriteLine();
            Console.WriteLine($"VALORES ATUALIZADOS: \n{b}");
        }
    }
}
