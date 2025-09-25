using System;
using System.Globalization;

/*
DateTime d1 = DateTime.Now;
Console.WriteLine(d1);
Console.WriteLine(d1.Ticks);
*/

// Demo - construtores
/*DateTime d1 = new DateTime(2000, 8, 15);
DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
Console.WriteLine(d1);
Console.WriteLine(d2);
Console.WriteLine(d3);*/

//Demo - Now, UtcNow, Today
/*DateTime d1 = DateTime.Now;
DateTime d2 = DateTime.UtcNow;
DateTime d3 = DateTime.Today;
Console.WriteLine(d1);
Console.WriteLine(d2);
Console.WriteLine(d3);*/

//Demo - ParseExact
DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
Console.WriteLine(d1);
Console.WriteLine(d2);