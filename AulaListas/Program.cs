using System;
using System.Collections.Generic;

namespace AulaListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Vinícius");
            list.Add("Marcio");
            list.Add("Pedro");
            list.Add("Marcela");
            list.Add("Paulinho");
            list.Add("Raimundo");
            list.Add("Joaquim");
            list.Add("Larissa");
            list.Add("Bruna");
            list.Insert(2, "Angela");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine($"List count: {list.Count}");

            string s1 = list.Find(x => x[0] == 'M');
            Console.WriteLine($"First 'M': {s1}");

            string s2 = list.FindLast(x => x[0] == 'M');
            Console.WriteLine($"Last 'M': {s2}");

            int pos1 = list.FindIndex(x => x[0] == 'M');
            Console.WriteLine($"First position 'M': {pos1}");

            int pos2 = list.FindLastIndex(x => x[0] == 'M');
            Console.WriteLine($"Last position 'M': {pos2}");

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-------------------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Vinícius");
            Console.WriteLine("-------------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-------------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(1);
            Console.WriteLine("-------------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2, 2);
            Console.WriteLine("-------------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
