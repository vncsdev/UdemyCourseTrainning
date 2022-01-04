using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Aluno
{
    internal class Aluno
    {
        public String Nome;
        public double Tri1, Tri2, Tri3;

        public double NotaFinal()
        {
            return Tri1 + Tri2 + Tri3;
        }

        public double PontosRestantes()
        {
            return 60 - NotaFinal();
        }
    }
}
