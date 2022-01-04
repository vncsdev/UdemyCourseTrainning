using System;

namespace Retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre com a altura e largura do retângulo:");
            Console.Write("Altura: ");
            ret.Altura = double.Parse(Console.ReadLine());
            Console.Write("Largura: ");
            ret.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Área: {ret.Area().ToString("F2")}\n" +
                              $"Perímetro: {ret.Perimetro().ToString("F2")}\n" +
                              $"Diagonal: {ret.Diagonal().ToString("F2")}");
        }
    }
}
