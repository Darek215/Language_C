// Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите 3 числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int max;
if (num1 > num2)
{
    if (num1 > num3)
    {
        max = num1;
    }
    else max = num3;
}
else 
{
    if (num2 > num3)
    {
        max = num2;
    }
    else
    {
        max = num3;
    }
}
Console.Write("Максимальное число: ");
Console.WriteLine(max);