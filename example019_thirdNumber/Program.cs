// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int[] arr = number.ToString().ToCharArray().Select(x => x - '0').ToArray();
if (number >= 100)
{
    int thirdNumber = arr[2];
    Console.WriteLine($"Третья цифра числа - {thirdNumber}");
}
else 
{
    Console.WriteLine("В числе меньше трех цифр!");
}