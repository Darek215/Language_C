// Пользователь вводит с клавиатуры число М.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.WriteLine("Введите число М: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[M];

void arraynums(int M)
{
    int i;
    for (i = 0; i < M; i++)
    {
        Console.WriteLine("Введите число: ");
        nums[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int array(int[] nums)
{
    int count = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if(nums[i] > 0)
        count ++;
    }
    return count;
}
arraynums(M);


Console.WriteLine("Чисел больше 0: " + array(nums));