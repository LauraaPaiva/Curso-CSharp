using System;
using System.Globalization;

namespace _4Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Nome:");
            f.Nome = Console.ReadLine();

            Console.Write("Salário:");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto:");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\n" + f);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            f.AumentarSalario(porcentagem);

            Console.WriteLine("Dados atualizados: " + f.Nome + ", $ " + f.SalarioBruto);



        }
    }
}
