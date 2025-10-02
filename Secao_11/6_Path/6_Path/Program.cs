string path = @"C:\Users\joao\Documents\_Curso C# Nelio Alves\Secao_11\myfolder\file1.txt";

Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
Console.WriteLine("PathSeparator: " + Path.PathSeparator);
Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
Console.WriteLine("GetFileName: " + Path.GetFileName(path));
Console.WriteLine("GetExtension: " + Path.GetExtension(path));
Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
Console.WriteLine("GetTempPath: " + Path.GetTempPath());
