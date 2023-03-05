// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов на нечётных позициях
int[] GetArray(int size, int minvalue, int maxvalue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minvalue, maxvalue + 1);
    }
    return result;
}

int result(int[] el)
{
    int sum = 0;
    for (int i = 0; i < el.Length; i++)
    {
        if (el[i] % 2 == 0)
        {
            sum++;
        }
    }
    return sum;
}

int[] array = GetArray(5, 1, 100);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(result(array));