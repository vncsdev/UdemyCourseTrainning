using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourseTrainning
{
    class Calculadora
    {
        static public double pi = 3.14;

        static public double Circunferencia(double r)
        {
            return 2.0 * pi * r;
        }

        static public double Volume(double r)
        {
            return 4.0 / 3.0 * pi * Math.Pow(r, 3.0);
        }
    }
}
