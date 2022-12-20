// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine()!;
int length = number.Length;
string _is = " ";

if (length == 5)
{
    for (int i = 0; i <= (length - 1)/2; i++)
    {
        if (number[i] == number[length - 1 - i]) 
        {
            _is = "- это палиндром";
        }
        else 
        {
            _is = "- это не палиндром";
            break;
        }
    }
    Console.WriteLine($"Число {number} {_is}");
}
else Console.WriteLine($"Вы ввели не пятизначное число!");