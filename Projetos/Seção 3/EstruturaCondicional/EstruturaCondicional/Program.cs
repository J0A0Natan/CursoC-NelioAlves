Console.Write("Entre com um numero inteiro: ");
int x = int.Parse(Console.ReadLine());

if (x % 2 == 0)
{
    Console.WriteLine($"{x} é par");
}
else
{
    Console.WriteLine($"{x} é impar");
}

Console.WriteLine("Qual a hora atual?");
int hora = int.Parse(Console.ReadLine());

if (hora < 12)
    Console.WriteLine("Bom dia!");
else if (hora < 18)
    Console.WriteLine("Boa tarde!");
else
    Console.WriteLine("Boa noite!");