// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
Console.WriteLine("Введите первый элемент числа: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй элемент числа: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третий элемент числа: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите четвёртый элемент числа: ");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите пятый элемент числа: ");
int e = Convert.ToInt32(Console.ReadLine());
if (a == e & b == d)
{
    Console.WriteLine("Число является палиндромом");
}
else 
{
    Console.WriteLine("Число не является палиндромом");
}