using _5_ClassesAbstratas;
using _5_ClassesAbstratas.Entities;
using System.Globalization;

List<Account> list = new List<Account>();

list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

double sum = 0.0;
foreach (Account account in list)
{
    sum += account.Balance;
}

Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

foreach (Account account in list)
{
    account.Withdraw(10.0);
}

foreach (Account acc in list)
{
    Console.WriteLine($"Updated balance for account {acc.Number}: {acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
}
