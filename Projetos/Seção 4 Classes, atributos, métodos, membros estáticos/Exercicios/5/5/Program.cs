using System.Globalization;
using _5;

Aluno aluno = new Aluno();

Console.Write("Nome do aluno: ");
aluno.Nome = Console.ReadLine();

Console.WriteLine("Digite as tres notas do aluno:");
aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("NOTA FINAL = " + aluno.CalculaNotaFinal().ToString("F2"), CultureInfo.InvariantCulture);
if (aluno.Aprovado())
{
    Console.WriteLine("APROVADO");
}
else
{
    Console.WriteLine("REPROVADO");
    Console.WriteLine("FALTARAM " + aluno.PontosRestantes().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
}
