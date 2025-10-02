string[] pos = Console.ReadLine().Split(" ");
int a = int.Parse(pos[0]);
int b = int.Parse(pos[0]);

int[,] mat = new int[a, b];

for (int i = 0; i < a; i++)
{
    string[] values = Console.ReadLine().Split(" ");
    for (int j = 0; j < b; j++)
    {
        mat[i, j] = int.Parse(values[j]);
    }
}

int num = int.Parse(Console.ReadLine());

for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        if (mat[i, j] == num)
        {
            Console.WriteLine($"Position {i}, {j}:");
            if (j > 0)
                Console.WriteLine($"Left: {mat[i, j - 1]}");
            if (i > 0)
                Console.WriteLine($"Up: {mat[i - 1, j]}");
            if (j < b - 1)
                Console.WriteLine($"Right: {mat[i, j + 1]}");
            if (i < a - 1)
                Console.WriteLine($"Down: {mat[i + 1, j]}");
        }
    }
}