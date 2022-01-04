using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExConversorDeMoeda
{
    internal class ConversorDeMoeda
    {
        static double iof = 6.00;

        static public double ValorEmReais(double cot, double qtd)
        {
            double total = cot * qtd;
            return total + total * iof / 100;
        }
    }
}
