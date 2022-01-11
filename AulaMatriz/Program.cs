using System;

namespace AulaMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) // linhas
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) // colunas
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
        }
    }
}
