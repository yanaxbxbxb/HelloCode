// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int count = 1;
while (count <= N)
{
//  Console.WriteLine(Math.Pow(count, 2));
    Console.Write($"{Math.Pow(count, 2)} ^_^ " );
    count++;
}
