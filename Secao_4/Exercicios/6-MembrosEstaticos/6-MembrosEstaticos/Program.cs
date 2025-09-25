using System.Globalization;
using _6_MembrosEstaticos;

Console.Write("Qual é a cotação do dólar? ");
double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantos dólares você vai comprar? ");
double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.DolarParaReal(dolares, cotacao).ToString("F2", CultureInfo.InvariantCulture));