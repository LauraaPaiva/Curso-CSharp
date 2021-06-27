using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EFix78
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AumentarSalario (int percentualDeAumento)
        {
            Salario += Salario * (percentualDeAumento / 100);
        }

    }
}
