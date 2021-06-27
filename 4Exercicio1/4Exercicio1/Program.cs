using System;
using System.Globalization;

namespace _4Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura do retângulo:");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = "+r.Area().ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMERO = " + r.Perimetro().ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString(CultureInfo.InvariantCulture));
        }
    }
}
