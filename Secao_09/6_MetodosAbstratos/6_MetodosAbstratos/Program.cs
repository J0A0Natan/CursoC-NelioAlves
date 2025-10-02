using System.Globalization;
using _6_MetodosAbstratos.Entities;
using _6_MetodosAbstratos.Entities.Enums;

Console.Write("Enter the number of shapes: ");
int n = int.Parse(Console.ReadLine());

List<Shape> list = new List<Shape>();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Shape #{i} data:");
    Console.Write("Rectangle or Circle (r/c)? ");
    char ch = char.Parse(Console.ReadLine());

    Console.Write("Color (Black/Blue/Red): ");
    Color color = Enum.Parse<Color>(Console.ReadLine());

    if (ch == 'r')
    {
        Console.Write("Width: ");
        double w = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Height: ");
        double h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new Rectangle(w, h, color));
    }
    else
    {
        Console.Write("Radius: ");
        double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new Circle(r, color));
    }
}

Console.WriteLine();
Console.WriteLine("SHAPE AREAS");
foreach (Shape shape in list)
{
    Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
}