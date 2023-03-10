// Задайте двумерный массив разметор M x N, заполненный
// случайными вещественными числами.
Console.WriteLine("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = new Random().NextDouble() * 20 - 10;
        Console.Write(arr[i,j] + " ");
    }
    Console.WriteLine();
}

