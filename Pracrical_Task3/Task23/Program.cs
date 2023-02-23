// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int count = 1;
int kub = 0;
while (count <= N)
{
    Console.WriteLine(kub = count * count * count);
    count = count + 1;
}