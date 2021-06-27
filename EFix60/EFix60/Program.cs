using System;

namespace EFix60
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial (s/n)? ");
            string existedpi = Console.ReadLine();

            ContaBancaria contab = new ContaBancaria(conta, titular);

            if (existedpi == "s")
            {
                Console.WriteLine("Entre o valor de depósito inicial: ");
                double dpi = double.Parse(Console.ReadLine());
                contab.Deposito(dpi);
            }

            Console.WriteLine(contab);

            Console.WriteLine("Entre com um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine());
            contab.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contab);

            Console.WriteLine("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());
            contab.Saque(saque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contab);


        }
    }
}
