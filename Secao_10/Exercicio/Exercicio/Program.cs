using Exercicio.Entities;
using Exercicio.Entities.Exceptions;
using System.Globalization;

Console.WriteLine("Enter account data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Holder: ");
string holder = Console.ReadLine();

Console.Write("Initial balance: ");
double inicialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Withdraw limit: ");
double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Account acc =  new Account(number, holder, inicialBalance, withdrawLimit);

try
{
    Console.Write("Enter amount for withdraw: ");
    double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    acc.Withdraw(withdraw);
    Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
}
catch (DomainException e)
{
    Console.WriteLine("Withdraw error: " + e.Message);
}
catch (FormatException e)
{
    Console.WriteLine("Format error: " + e.Message);
}