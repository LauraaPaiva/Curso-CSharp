using System;
using System.Globalization;

namespace EFix81
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a dimensão da matriz? (m x n)");
            string[] dim = Console.ReadLine().Split(" x ");

            int m = int.Parse(dim[0]);
            int n = int.Parse(dim[1]);

            int[,] matriz = new int[m, n];

            Console.WriteLine("Escreva a matriz:");

            for (int i = 0; i < m; i++)
            {
                string[] valoresLinha = Console.ReadLine().Split(" ");

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valoresLinha[j]);
                }
            }

            Console.WriteLine("Valor procurado:");
            int valorProducurado = int.Parse(Console.ReadLine());

            int valoresEncontrados = 0;


            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == valorProducurado)
                    {
                        Console.WriteLine("Valor encontrado na posição (" + (i + 1) + ", " + (j + 1) + ")");

                        if (j - 1 >= 0)
                        {
                            Console.WriteLine("Esquerda: " + matriz[i, j - 1]);
                        }

                        if (j + 1 < n)
                        {
                            Console.WriteLine("Direita: " + matriz[i, j + 1]);
                        }

                        if (i - 1 >= 0)
                        {
                            Console.WriteLine("Acima: " + matriz[i - 1, j]);
                        }

                        if (i + 1 < m)
                        {
                            Console.WriteLine("Abaixo: " + matriz[i + 1, j]);
                        }

                        valoresEncontrados += 1;
                    }
                }
            }

            Console.WriteLine("Número de valores encontrados: " + valoresEncontrados.ToString("F0", CultureInfo.InvariantCulture));



        }
    }
}
