using Exercicio.Entities;
using System.Globalization;

string path = @"C:\Users\joao\Documents\_Curso C# Nelio Alves\Secao_11\Exercicio\myfolder\source.csv";

string[] lines = File.ReadAllLines(path);

string folder = Path.GetDirectoryName(path);
string targetFolder = folder + @"\out";
string targetFile = targetFolder + @"\summary.csv";

try
{
    Directory.CreateDirectory(targetFolder);

    using (StreamWriter sw = new StreamWriter(targetFile))
    {
        foreach (string line in lines)
        {
            string[] data = line.Split(",");
            string name = data[0];
            double price = double.Parse(data[1], CultureInfo.InvariantCulture);
            int quant = int.Parse(data[2]);

            Product p = new Product(name, price, quant);

            sw.WriteLine($"{p.Name},{p.Total().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}