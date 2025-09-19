using Exercicio;

Pessoa a, b;
a = new Pessoa();
b = new Pessoa();

Console.WriteLine("Dados da primeira pessoa:");
Console.Write("Nome: ");
a.Nome = Console.ReadLine();
a.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados da segunda pessoa:");
Console.Write("Nome: ");
b.Nome = Console.ReadLine();
b.Idade = int.Parse(Console.ReadLine());

Console.Write("Pessoa mais velha: ");
if (a.Idade > b.Idade)
    Console.WriteLine(a.Nome);
else
    Console.WriteLine(b.Nome);