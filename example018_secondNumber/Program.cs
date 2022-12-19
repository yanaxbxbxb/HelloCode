// Напишите программу, которая принимает на вход трёхзначное число 
//  и на выходе показывает вторую цифру этого числа.

Console.Write("Введите число от 100 до 999: ");
int number = int.Parse(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int secondNumber = (number / 10) % 10;
    Console.WriteLine($"Вторая цифра числа - {secondNumber}");
}
else 
{
    Console.WriteLine("Вы ввели не трехзначное число!");
}