using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EFix60
{
    class ContaBancaria
    {
        public int Conta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
            Saldo = 0;
        }

        public void Deposito (double deposito)
        {
            Saldo += deposito;
        }

        public void Saque (double saque)
        {
            Saldo -= saque;
            Saldo -= 5;
        }

        public override string ToString()
        {
            return "Dados da conta:\n"
                + "Conta: "
                + Conta
                + ", Titular: "
                + Titular
                + ", Saldo: R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
