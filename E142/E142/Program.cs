using E142.Entities;
using System;
using System.Diagnostics;
using System.Globalization;

namespace E142
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Commin, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch(type)
                {
                    case 'c':

                        list.Add(new Product(name, price));

                        break;

                    case 'u':

                        Console.Write("Manufactory date (DD/MM/YYYY): ");
                        DateTime manufactoryDate = DateTime.Parse(Console.ReadLine());

                        list.Add(new UsedProduct(name, price, manufactoryDate));

                        break;

                    case 'i':

                        Console.Write("Custom fee: ");
                        double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        list.Add(new ImportedProduct(name, price, customFee));

                        break;

                    default:

                        Console.WriteLine("Produto com tipo incorreto.");

                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach(Product p in list)
            {
                Console.WriteLine(p.PriceTag());
            }

        }
    }
}