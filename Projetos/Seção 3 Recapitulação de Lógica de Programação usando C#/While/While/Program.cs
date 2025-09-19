using System.Globalization;

/*Console.Write("Digite um numero: ");
double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

while (x >= 0.0)
{
    double raiz = Math.Sqrt(x);
    Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));

    Console.Write("Digite outro numero: ");
    x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}
Console.WriteLine("Número negativo!");*/

// Ex1
string senha = Console.ReadLine();

while (senha != "2002")
{
    Console.WriteLine("Senha Invalida");
    senha= Console.ReadLine();
}
Console.WriteLine("Acesso Permitido");