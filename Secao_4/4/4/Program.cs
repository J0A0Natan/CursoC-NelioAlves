using _4;
using System.Globalization;

Produto p = new Produto();

Console.WriteLine("Entre com os dados do produto:");
Console.Write("Nome: ");
p.Nome = Console.ReadLine();
Console.Write("Preço: ");
p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque: ");
p.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados do produto: " + p);

Console.WriteLine();
Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
int qnt = int.Parse(Console.ReadLine());
p.AdicionarProdutos(qnt);
Console.WriteLine("Dados atualizados: " + p);

Console.WriteLine();
Console.Write("Digite o numero de produtos a ser removido do estoque: ");
qnt = int.Parse(Console.ReadLine());
p.RemoverProdutos(qnt);
Console.WriteLine("Dados atualizados: " + p);