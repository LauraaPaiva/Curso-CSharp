// See https://aka.ms/new-console-template for more information
using E155.Entities;
using E155.Exceptions;
using System.Globalization;

try
{

    Console.WriteLine("Enter account data");

    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());

    Console.Write("Holder: ");
    string holder = Console.ReadLine();

    Console.Write("Initial balance: ");
    double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Withdraw limit: ");
    double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine();
    Console.Write("Enter amount for withdraw: ");
    double withdrawValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Account acc = new Account(number, holder, balance, withdrawLimit);
    acc.Withdraw(withdrawValue);

    Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));

}
catch (FormatException e)
{
    Console.WriteLine("Error in format: " + e.Message);
}
catch (DomainException e)
{
    Console.WriteLine("Withdraw error: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Unexpexted error: " + e.Message);
}
