using System;
using System.Globalization;

namespace EFix71
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int nquartos = 10;

            Quarto[] quarto = new Quarto[nquartos];

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nNome: ");
                string name = Console.ReadLine();

                Console.Write("E-mail: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int q = int.Parse(Console.ReadLine());

                quarto[q] = new Quarto { Name = name, Email = email };

            }

            int aluguel = 1;

            for (int u = 0; u < nquartos; u++)
            {
                if (quarto[u] != null)
                {
                    Console.WriteLine("\nAluguel #" + aluguel);
                    Console.WriteLine("Name: " + quarto[u].Name);
                    Console.WriteLine("E-mail: " + quarto[u].Email);
                    Console.WriteLine("Quarto: " + u);
                    aluguel++;
                }

            }

        }
    }
}
