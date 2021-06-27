using System;
using System.Globalization;

namespace EFix48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dólar?");
            double cota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar?");
            double compradol = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double comprareais = ConversorDeMoeda.comprareais(cota, compradol);

            Console.WriteLine("Valor a ser pago em reais = "+comprareais.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
