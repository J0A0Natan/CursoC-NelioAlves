using System.Globalization;
using exercício_de_fixacao;

ContaBancaria conta;

Console.Write("Entre o número da conta: ");
int numero = int.Parse(Console.ReadLine());

Console.Write("Entre o titular da conta: ");
string titular = Console.ReadLine();

Console.Write("Haverá depósito inicial (s/n)? ");
if (Console.ReadLine().ToLower() == "s")
{
    Console.Write("Entre o valor de depósito inicial: ");
    double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new ContaBancaria(numero, titular, saldo);
}
else
{
    conta = new ContaBancaria(numero, titular);
}

Console.WriteLine("Dados da conta:");
Console.WriteLine(conta);

Console.Write("\nEntre um valor para depósito: ");
conta.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(conta);

Console.Write("\nEntre um valor para saque: ");
conta.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(conta);