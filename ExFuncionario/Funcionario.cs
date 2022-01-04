using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFuncionario
{
    internal class Funcionario
    {
        public String Nome;
        public double SalBruto;
        public double Imposto;

        public double SalLiquido()
        {
            return SalBruto - Imposto;
        }

        public void AumentoSalario(double aumento)
        {
            aumento /= 100;
            SalBruto += (SalBruto * aumento);
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\n" +
                   $"Salário Líquido: {SalLiquido().ToString("C")}";
        }
    }
}
