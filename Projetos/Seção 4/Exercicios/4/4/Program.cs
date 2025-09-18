using System.Globalization;
using _4;

Funcionario f1 = new Funcionario();

Console.Write("Nome: ");
f1.Nome = Console.ReadLine();

Console.Write("Salario bruto: ");
f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Imposto: ");
f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Funcionario: " + f1);

Console.Write("\nDigite a porcentagem para aumentar o salario: ");
double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
f1.AumentarSalario(porcentagem);

Console.WriteLine("\nDados atualizados: " + f1);