string path = @"C:\Users\joao\Documents\_Curso C# Nelio Alves\Secao_11\myfolder";

try
{
    IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("FOLDERS:");
    foreach (string s in folders)
    {
        Console.WriteLine(s);
    }

    IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("FILES:");
    foreach (string f in files)
    {
        Console.WriteLine(f);
    }

    Directory.CreateDirectory(path + @"\newfolder");
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}