using System;
using System.Collections.Generic;
using System.Globalization;

namespace EFix78
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o número de funcionários?");
            int nFuncionarios = int.Parse(Console.ReadLine());

            List<Funcionario> Funcionarios = new List<Funcionario>();

            for (int i = 1; i <= nFuncionarios; i++)
            {
                Console.WriteLine("Funcionário #" + i + ":");

                Console.Write("ID: ");
                int fid = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string fnome = Console.ReadLine();

                Console.Write("Salário: ");
                double fsalario = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

                Console.WriteLine(fid + fnome + fsalario);

                Funcionarios.Add(new Funcionario(fid, fnome, fsalario));

            }

            Console.WriteLine("Qual o ID do funcionário que terá aumento?");
            int fIdAumento = int.Parse(Console.ReadLine());

            Funcionario func = Funcionarios.Find(x => x.Id == fIdAumento);

            if (func != null)
            {
                Console.WriteLine("Qual a porcentagem do aumento?");
                int percAumento = int.Parse(Console.ReadLine());
                func.AumentarSalario(percAumento);
            }
            else
            {
                Console.WriteLine("ID não encontrado!");
            }

            foreach (Funcionario obj in Funcionarios)
            {
                Console.WriteLine("Dados dos funcionários:");
                Console.WriteLine(obj.ToString());
            }




        }
    }
}
