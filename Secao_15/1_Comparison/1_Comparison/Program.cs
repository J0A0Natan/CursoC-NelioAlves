using _1_Comparison.Entities;
using System.Xml.Linq;

List<Product> list = new List<Product>();

list.Add(new Product("TV", 900.00));
list.Add(new Product("Notebook", 1200.00));
list.Add(new Product("Tablet", 450.00));

//Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

//list.Sort(CompareProducts);
//list.Sort(comp);
list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));// (p1, p2) => ... Expressão lambda

foreach (Product prod in list)
{
    Console.WriteLine(prod);
}

//static int CompareProducts(Product p1, Product p2)
//{
//    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
//}