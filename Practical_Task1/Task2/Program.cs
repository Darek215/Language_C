// Задача 2: Напишите программу, которая на вход принимает два 
// числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max, min;
if (num1 < num2)
{
    max = num2; 
    min = num1;
}
else 
{
    max = num1; 
    min = num2;
}

Console.Write("Большее число: ");
Console.WriteLine(max);
Console.Write("Меньшее число: ");
Console.WriteLine(min);