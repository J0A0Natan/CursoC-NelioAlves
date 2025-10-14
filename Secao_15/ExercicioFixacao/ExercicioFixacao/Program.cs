using ExercicioFixacao.Entities;
using System.Globalization;

string path = @"C:\Users\joao\Documents\_Curso C# Nelio Alves\Secao_15\ExercicioFixacao\in.txt";

List<Employee> list = new List<Employee>();

using (StreamReader sr = File.OpenText(path))
{
    while (!sr.EndOfStream)
    {
        string[] line = sr.ReadLine().Split(",");
        string name = line[0];
        string email = line[1];
        double sala = Double.Parse(line[2], CultureInfo.InvariantCulture);

        list.Add(new Employee(name, email, sala));
    }
}

Console.Write("Enter salary: ");
double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Email of people whose salary is more than " + salary.ToString("F2", CultureInfo.InvariantCulture));
//var emails = list.Where(e => e.Salaray > salary).OrderBy(e => e.Email).Select(e => e.Email);
var emails = 
    from e in list
    where e.Salaray > salary
    orderby e.Email
    select e.Email;

foreach (string email in emails)
{
    Console.WriteLine(email);
}

var sum = list.Where(e => e.Name[0] == 'M').Sum(e => e.Salaray);
Console.Write("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
