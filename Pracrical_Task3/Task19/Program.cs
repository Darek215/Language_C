// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите четвёртое число: ");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите пятое число: ");
int e = Convert.ToInt32(Console.ReadLine());
if (a == e & b == d)
{
    Console.WriteLine("Число является палиндромом");
}
else 
{
    Console.WriteLine("Число не является палиндромом");
}