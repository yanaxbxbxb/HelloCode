// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int M = ReadInt("M");

CountPositiveNumbers(M);


int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine()!);
}

void CountPositiveNumbers(int M)
{
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        int number = ReadInt("number");
        if (number > 0) {count++;}
    }
    System.Console.WriteLine($"You input {count} positive numbers");
}