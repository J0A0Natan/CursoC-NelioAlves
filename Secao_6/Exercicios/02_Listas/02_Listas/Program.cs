using _02_Listas;
using System.Globalization;
using System.Collections.Generic;

List<Employee> list = new List<Employee>();

Console.Write("How many employees will be registered? ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Emplyoee #{i}:");
    Console.Write("Id: ");
    int idE = int.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    list.Add(new Employee { id = idE, name = name, salary = salary });
    Console.WriteLine();
}

Console.Write("Enter the employee id that will have salary increase :");
int id  = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Employee emp = list.Find(x => x.id == id);

if (emp != null)
{
    Console.Write("Enter the percentage :");
    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    emp.increaseSalary(percentage);
}
else
{
    Console.WriteLine("This id doesn't exist!");
}

Console.WriteLine("\nUpdated list of employees:");
foreach  (Employee e in list)
{
    Console.WriteLine(e);
}