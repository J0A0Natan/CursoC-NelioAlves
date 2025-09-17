using System.Globalization;
// Parte 1
/*string frase = Console.ReadLine();
string x = Console.ReadLine();
string y = Console.ReadLine();
string z = Console.ReadLine();

string[] vet = Console.ReadLine().Split(' ');

string a = vet[0];
string b = vet[1];
string c = vet[2];

Console.WriteLine("Voce digitou:");
Console.WriteLine(frase);
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);*/

// Parte 2
/*int n1 = int.Parse(Console.ReadLine());
char ch = char.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

string[] v = Console.ReadLine().Split(' ');
string nome = v[0];
char sexo = char.Parse(v[1]);
int idade = int.Parse(v[2]);
double altura = double.Parse(v[3], CultureInfo.InvariantCulture);


Console.WriteLine("Voce digitou:");
Console.WriteLine(n1);
Console.WriteLine(ch);
Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(nome);
Console.WriteLine(sexo);
Console.WriteLine(idade);
Console.WriteLine(altura);*/

// Exercicio de fixação
Console.WriteLine("Digite seu nome completo: ");
string nome = Console.ReadLine();
Console.WriteLine("Quantos quartos tem na sua casa?");
int quartos = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com um preço de um produto:");
double prod = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Seu ultimo nome, idade e altura (mesma linha):");
string[] v = Console.ReadLine().Split(' ');
string ultimoNome = v[0];
int idade = int.Parse(v[1]);
double altura = double.Parse(v[2], CultureInfo.InvariantCulture);

Console.WriteLine(nome);
Console.WriteLine(quartos);
Console.WriteLine(prod.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(ultimoNome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));