using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo
{
    internal class Retangulo
    {
        public double Altura;
        public double Largura;

        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return (Altura + Largura) * 2;
        }

        public double Diagonal()
        {
            double dgnl = Math.Pow(Altura, 2.0) + Math.Pow(Largura, 2.0);
            return Math.Sqrt(dgnl);
        }
    }
}
