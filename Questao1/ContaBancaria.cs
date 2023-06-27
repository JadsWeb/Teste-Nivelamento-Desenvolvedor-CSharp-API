using System;
using System.Globalization;

namespace Questao1
{
    class ContaBancaria {
        public ContaBancaria(int numero, string nome, double depositoIni = 0)
        {
            this.Conta = numero;
            this.Nome = nome;
            this.ValorConta += depositoIni;
        }

        public int Conta { get; set; }
        public string Nome { get; set; }
        public double ValorConta { get; set; }

        public double TaxaSaque = 3.50;

        public void Deposito(double quantia)
        {
            ValorConta += quantia;
        }

        public void Saque(double quantia)
        {
            ValorConta -= TaxaSaque;
            ValorConta -= quantia;
        }
    }
}
