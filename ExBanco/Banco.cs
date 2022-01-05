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

        public Banco(string nome, int conta)
        {
            _nome = nome;
            Conta = conta;
        }

        public Banco(string nome, int conta, double depInicial) : this(nome, conta)
        {
            Saldo = depInicial;
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

        public static double TaxaSaque = 5.00;

        public void Deposito(double dep)
        {
            Saldo += dep;
        }

        public void Saque(double saque)
        {
            Saldo -= saque + TaxaSaque;
        }

        public override string ToString()
        {
            return $"Conta: {Conta}\n" +
                   $"Titular: {_nome}\n" +
                   $"Saldo: {Saldo.ToString("C")}";
        }

    }
}
