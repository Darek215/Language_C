// Задайте двумерный массив. Напишите прогрумму, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

int[,] regul(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int a = 0; a < array.GetLength(1) - 1; a++)
        {
            int min = array[i, 0];
            int b = 0;
            for (int j = 0; j < array.GetLength(1) - a; j++)
            {
                if (min > array[i, j])
                {
                    min = array[i, j];
                    b = j;
                }
            }
            int step = array[i, array.GetLength(1) - 1 - a];
            array[i, array.GetLength(1) - 1 - a] = array[i, b];
            array[i, b] = step;
        }
    }
    return array;
}

int[,] Write(int m = 4, int n = 4)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(1, 11);
        }
    }
    return array;
}

void Fin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.Write("{0,4}", array[i,j]);
        }
        Console.WriteLine();
    }
}

int[,] Array = Write();
Fin(Array);
Console.WriteLine();
Fin(regul((int[,]) Array.Clone()));