/*Console.Write("Quantos numeros inteiros voce vai digitar? ");
int n = int.Parse(Console.ReadLine());
int soma = 0;

for (int i = 1; i <= n; i++)
{
    Console.Write($"{i}° valor: ");
    int num = int.Parse(Console.ReadLine());
    soma += num;
}
Console.WriteLine($"Soma: {soma}");*/

/*
 * Exercício 01
 * Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1067/uri1067/Program.cs
 * Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.
*/
/*Console.Write("Digite um valor: ");
int valor = int.Parse(Console.ReadLine());

for (int i = 1; i <= valor; i++)
{
    if (!(i % 2 == 0))
        Console.WriteLine(i);
}*/

/*
Exercício 02
Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1072/uri1072/Program.cs
Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
*/
Console.Write("Quantos numeros voce vai digitar? ");
int n = int.Parse(Console.ReadLine());
int quantIn = 0;
int quantOut = 0;

for (int i = 1; i <= n; i++)
{
    Console.Write($"{i}° valor: ");
    int num = int.Parse(Console.ReadLine());
    if (num >= 10 && num <= 20)
        quantIn++;
    else
        quantOut++;
}
Console.WriteLine($"In: {quantIn}");
Console.WriteLine($"Out: {quantOut}");
