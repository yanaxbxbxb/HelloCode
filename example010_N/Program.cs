﻿// int n = int.Parse(Console.ReadLine());
// int count = (-n);

// while (count <= n)
// {
//     Console.Write($"{count}, ");
//     count = count +1;
// }

Console.Write("Введите трехзначное число: ");
if (int.TryParse(Console.ReadLine(), out int n))
{
        if (n >= 100 && n < 1000)
        {
            int x = n % 10;
            Console.Write($"Последняя цифра вашего числа {x}");
        }
        else 
        {
            System.Console.WriteLine("Вы ввели не трехзначное число!");
        }
}
else 
{
    System.Console.WriteLine("Вы ввели не число!");
}
