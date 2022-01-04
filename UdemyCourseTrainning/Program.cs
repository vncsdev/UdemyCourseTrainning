using System;
using System.Globalization;

namespace UdemyCourseTrainning
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira o valor do raio 1: ");
            double raio = double.Parse(Console.ReadLine());

            double vol = Calculadora.Volume(raio);

            Console.WriteLine();

            Console.WriteLine($"Circunferência: {Calculadora.Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {vol.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            Console.WriteLine($"Pi: {Calculadora.pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
