string sourcePath = @"C:\Users\joao\Documents\_Curso C# Nelio Alves\Secao_11\file1.txt";
string targetPath = @"C:\Users\joao\Documents\_Curso C# Nelio Alves\Secao_11\file2.txt";

try
{
    string[] lines = File.ReadAllLines(sourcePath);

    using (StreamWriter sw = File.AppendText(targetPath))
    {
        foreach (string line in lines)
        {
            sw.WriteLine(line.ToUpper());
        }
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}