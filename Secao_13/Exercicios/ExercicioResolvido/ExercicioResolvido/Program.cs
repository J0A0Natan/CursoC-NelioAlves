using ExercicioResolvido.Entities;

//Console.Write("Enter the full path: ");
//string path = Console.ReadLine();

string path = @"C:\Users\joao\Documents\_Curso C# Nelio Alves\Secao_13\ExercicioResolvido\in.txt";

HashSet<LogRecord> set = new HashSet<LogRecord>();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(' ');
            string name = line[0];
            DateTime instant = DateTime.Parse(line[1]);
            set.Add(new LogRecord { Username = name, Instant = instant});
        }
        Console.WriteLine("Total users: " + set.Count);
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}