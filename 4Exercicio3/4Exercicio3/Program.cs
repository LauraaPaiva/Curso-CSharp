using System;
using System.Globalization;

namespace _4Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Nome do Aluno: ");
            a.Nome = Console.ReadLine();

            Console.Write("Digite as três notas do aluno:\n");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = "+a.NotaFinal().ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(a.Resultado());

        }
    }
}
