using Cronstrutores;
using System;
using System.Globalization;
namespace Cronstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("TV", 500.00, 10);

            Console.WriteLine(produto.GetNome());

            produto.SetNome("TV 4K");

            Console.WriteLine(produto.GetNome());
        }
    }
}