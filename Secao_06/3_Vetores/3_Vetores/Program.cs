using _3_Vetores;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

/*int n = int.Parse(Console.ReadLine());

double[] vect = new double[n];
double avg = 0;

for (int i = 0; i < n; i++)
{
    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    avg += vect[i];
}

avg /= n;

Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));*/

int n = int.Parse(Console.ReadLine());
Product[] vect = new Product[n];
double avg = 0;

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    vect[i] = new Product { Name = name, Price = price };

    avg += price;
}

avg /= n;

Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2"), CultureInfo.InvariantCulture);