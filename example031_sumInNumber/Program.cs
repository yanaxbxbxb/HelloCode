//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void SumInNumber()
{
    string number = ReadInt("number").ToString();

    int result = Sum_of_digits(number);

    Console.Write($"Sum of digits in number {number} is {result}");
}

SumInNumber();

int ReadInt(string argumentName)
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine()!);
}

int Sum_of_digits(string number)
{
    int result = 0;
    for (int i = 0; i < number.Length; i++)
    {
        int a = int.Parse(number[i].ToString());
        result = result + a;
    }
    return result;
}
