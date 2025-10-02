using _01;

Aluno[] vet = new Aluno[10];

Console.Write("How many rooms will be rented? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Rent #" + (i + 1));
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Room: ");
    int room = int.Parse(Console.ReadLine());
    Console.WriteLine();

    vet[room] = new Aluno { Name = name, Email = email };
}

Console.WriteLine("Busy rooms:");
for (int i = 0; i < 10; i++)
{
    if (vet[i] != null)
    {
        Console.WriteLine($"{i}: {vet[i].Name}, {vet[i].Email}");
    }
}