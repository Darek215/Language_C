// Напишите программу, которая принимает на вход в цифту,
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 7)
{
    if (num <= 5)
    {
        Console.WriteLine("Нет");
    }
    else
    {
        Console.WriteLine("Да");
    }
}
else
{
    Console.WriteLine("Такого дня нет");
}