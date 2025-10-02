string path = @"C:\Users\joao\Documents\_Curso C# Nelio Alves\Secao_11\file1.txt";

/*try
{
    using (FileStream fs = new FileStream(path, FileMode.Open))
    {
        using (StreamReader sr = new StreamReader(fs))
        {
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
}*/
try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}