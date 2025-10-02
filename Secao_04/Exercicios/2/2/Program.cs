using _2;
using System.Globalization;

Funcionario a, b;
a = new Funcionario();
b = new Funcionario();

Console.WriteLine("Dados do primeiro funcionario:");
Console.Write("Nome: ");
a.Nome = Console.ReadLine();
Console.Write("Salario: ");
a.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Dados do segundo funcionario:");
Console.Write("Nome: ");
b.Nome = Console.ReadLine();
Console.Write("Salario: ");
b.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double salarioMedio = (a.Salario + b.Salario) / 2;
Console.WriteLine("Salario medio: " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));