using System.Globalization;

string prod1 = "Computador";
string prod2 = "Mesa de escritorio";

byte idade = 30;
int cod = 5290;
char genero = 'M';

double p1 = 2100.0;
double p2 = 650.50;
double medida = 53.234567;

Console.WriteLine("Produtos:");
Console.WriteLine($"{prod1}, cujo preço é $ {p1:F2}");
Console.WriteLine($"{prod2}, cujo preço é $ {p2:F2}\n");

Console.WriteLine($"Registro: {idade} anos de idade, código {cod} e gênero: {genero}\n");

Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
Console.WriteLine($"Arredondando (três casas decimais): {medida:F3}");
Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));