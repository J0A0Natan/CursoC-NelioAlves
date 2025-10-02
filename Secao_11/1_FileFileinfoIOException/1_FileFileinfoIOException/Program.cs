using System.IO;

string sourcePath = @"C:\Users\joao\Documents\_Curso C# Nelio Alves\Secao_11\file1.txt";
string targetPath = @"C:\Users\joao\Documents\_Curso C# Nelio Alves\Secao_11\file2.txt";

try
{
    FileInfo fileInfo = new FileInfo(sourcePath);

    fileInfo.CopyTo(targetPath);

    string[] lines = File.ReadAllLines(sourcePath);

    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}