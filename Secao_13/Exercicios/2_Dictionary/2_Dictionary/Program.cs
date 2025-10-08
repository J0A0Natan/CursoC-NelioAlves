string path = @"C:\Users\joao\Documents\_Curso C# Nelio Alves\Secao_13\Exercicios\2_Dictionary\in.txt";

Dictionary<string, int> votos = new Dictionary<string, int>();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] vect = sr.ReadLine().Split(',');
            string key = vect[0];
            int value = int.Parse(vect[1]);

            if (votos.ContainsKey(key))
            {
                votos[key] += value;
            }
            else
            {
                votos.Add(key, value);
            }
        }
    }

    foreach (KeyValuePair<string, int> item in votos)
    {
        Console.WriteLine(item.Key + ": " + item.Value);
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}