using System;

namespace ExBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n): ");
            char depInicial = char.Parse(Console.ReadLine().ToLower());

            if (depInicial == 's')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double valDepInicial = double.Parse(Console.ReadLine());

                Banco b = new Banco(titular, conta, valDepInicial);

                Console.WriteLine();
                Console.WriteLine("Dados da conta: \n" +
                                  $"Conta: {b.Conta}\n" +
                                  $"Titular: {b.Nome}\n" +
                                  $"Saldo: {b.Saldo}");
            }
            else if (depInicial == 'n')
            {
                Banco b1 = new Banco(titular, conta);

                Console.WriteLine();
                Console.WriteLine("Dados da conta: \n" + b1);
            }
            else
            {
                Console.WriteLine("Comando inválido, tente novamente");
            }

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double dep = double.Parse(Console.ReadLine());
        }
    }
}
