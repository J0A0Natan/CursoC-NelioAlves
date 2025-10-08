using _3_GetHashCode_Equals.Entities;

Client a = new Client() { Name = "Maria", Email = "maria@gmail.com" };
Client b = new Client() { Name = "Alex", Email = "alex@gmail.com" };

Console.WriteLine(a.Equals(b));
Console.WriteLine(a == b);
Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());
