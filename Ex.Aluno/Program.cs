using System;

namespace Ex.Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Nome do Aluno: ");
            a.Nome = Console.ReadLine();
            Console.Write("Nota 1º Trimetre: ");
            a.Tri1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2º Trimetre: ");
            a.Tri2 = double.Parse(Console.ReadLine());
            Console.Write("Nota 3º Trimetre: ");
            a.Tri3 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"NOTA FINAL: {a.NotaFinal().ToString("F2")}");

            if (a.NotaFinal() >= 60)
            {
                Console.WriteLine("SITUAÇÃO: Aprovado");
            }
            else
            {
                Console.WriteLine($"SITUAÇÃO: Reprovado\n" +
                                  $"FALTARAM: {a.PontosRestantes()} PONTOS");
            }
        }
    }
}
