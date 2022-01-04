using System;

namespace ExFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("Insira os dados do funcionário:");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f.SalBruto = double.Parse(Console.ReadLine());
            Console.Write("Desconto INSS: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(f);

            Console.WriteLine();
            Console.Write("Insira a % de aumento do salário: ");
            double aumento = double.Parse(Console.ReadLine());
            f.AumentoSalario(aumento);

            Console.WriteLine();
            Console.WriteLine($"Dados Atualizados: \n{f}");
        }
    }
}
