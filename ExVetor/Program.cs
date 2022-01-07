using System;

namespace ExVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("QUANTOS QUARTOS SERÃO ALUGADOS? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Pensionato[] rooms = new Pensionato[10];

            int quarto;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                rooms[quarto] = new Pensionato(name, email);
            }

            Console.WriteLine("QUARTOS OCUPADOS:");
            Console.WriteLine();
            for (int i = 0; i < x; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine($"Quarto {i}");
                    Console.WriteLine(rooms[i]);
                    Console.WriteLine();
                }
            }
            
        }
    }
}
