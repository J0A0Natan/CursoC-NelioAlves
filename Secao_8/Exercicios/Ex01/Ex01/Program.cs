using Ex01.Entities;
using Ex01.Entities.Enums;
using System.Globalization;

Console.WriteLine("Enter cliente data:");
Console.Write("Name: ");
string clientName = Console.ReadLine();

Console.Write("Email: ");
string clientEmail= Console.ReadLine();

Console.Write("Birth date (DD/MM/YYYY): ");
DateTime clientBirthDay = DateTime.Parse(Console.ReadLine());

Client client  = new Client(clientName, clientEmail, clientBirthDay);

Console.WriteLine("Enter order data:");
Console.Write("Status: ");
string s1 = Console.ReadLine();
OrderStatus status  = Enum.Parse<OrderStatus>(s1);

Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());

Order o1 = new Order(DateTime.Now, status, client);

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter #{i + 1} item data:");
    Console.Write("Product name: ");
    string name = Console.ReadLine();

    Console.Write("Product price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    Product product = new Product(name, price);
    OrdemItem item = new OrdemItem(quantity, price, product);
    o1.AddItem(item);
}

Console.WriteLine(o1);