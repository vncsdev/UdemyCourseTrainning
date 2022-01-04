using System;

namespace ExConversorDeMoeda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar? ");
            double dolar = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você vai comprar? ");
            double qtdDolar = double.Parse(Console.ReadLine());

            Console.WriteLine($"Valor a ser pago em reais: {ConversorDeMoeda.ValorEmReais(dolar, qtdDolar).ToString("C")}");
        }
    }
}
