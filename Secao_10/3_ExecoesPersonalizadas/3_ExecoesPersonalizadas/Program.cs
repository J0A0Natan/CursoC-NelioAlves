using _3_ExecoesPersonalizadas.Entities;
using _3_ExecoesPersonalizadas.Entities.Exceptions;

try
{
    Console.Write("Room number: ");
    int n = int.Parse(Console.ReadLine());

    Console.Write("Check-in date (dd/MM/yyyy): ");
    DateTime checkIn = DateTime.Parse(Console.ReadLine());

    Console.Write("Check-out date (dd/MM/yyyy): ");
    DateTime checkOut = DateTime.Parse(Console.ReadLine());

    Reservetion reservetion = new Reservetion(n, checkIn, checkOut);
    Console.WriteLine("Reservetion: " + reservetion);
    Console.WriteLine();

    Console.WriteLine("Enter data to update the reservation:");
    Console.Write("Check-in date (dd/MM/yyyy): ");
    checkIn = DateTime.Parse(Console.ReadLine());

    Console.Write("Check-out date (dd/MM/yyyy): ");
    checkOut = DateTime.Parse(Console.ReadLine());

    reservetion.UpdateDates(checkIn, checkOut);

    Console.WriteLine("Reservetion: " + reservetion);
}
catch (DomainException e)
{
    Console.WriteLine("Error in reservetion: " + e.Message);
}
catch (FormatException e)
{
    Console.WriteLine("Format error: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Unexpected error: " + e.Message);
}