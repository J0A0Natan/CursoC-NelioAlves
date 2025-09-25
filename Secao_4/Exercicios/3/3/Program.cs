using _3;
using System.Globalization;

Retangulo r = new Retangulo();

Console.WriteLine("Entre com a largura e a altura do retangulo:");
r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("AREA = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PERIMETRO = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
