using System;

namespace Terceiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int valor = 0;

            Console.WriteLine("Quantos números você vai digitar?");
            int quantidade = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= quantidade; ++contador)
            {
                Console.Write($"Valor #{contador}: ");
                valor = int.Parse(Console.ReadLine());
                soma = soma + valor;
            }

            Console.WriteLine($"Soma = {soma}");
        }
    }
}
