// Напишите программу, которая выводит третью цифру числа
// или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
{
    Console.WriteLine(num % 10);
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}
