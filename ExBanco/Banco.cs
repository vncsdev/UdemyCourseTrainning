using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExBanco
{
    internal class Banco
    {
        private string _nome;
        public int Conta { get; private set; }
        public double Saldo { get; private set; }

        public Banco(int conta, string nome)
        {
            Conta = conta;
            Nome = nome;
        }

        public Banco(int conta, string nome, double depInicial) : this(conta, nome)
        {
            Deposito(depInicial);
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public void Deposito(double dep)
        {
            Saldo += dep;
        }

        public void Saque(double saque)
        {
            Saldo -= saque + 5.00;
        }

        public override string ToString()
        {
            return $"Conta: {Conta}\n" +
                   $"Titular: {_nome}\n" +
                   $"Saldo: {Saldo.ToString("C")}";
        }

    }
}
