// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе

void TaskQuantity()
{
	Console.WriteLine("TaskQuantity");
	string number = ReadInt("number").ToString();
    
	Console.WriteLine($"Количество цифр в числе - {number.Length}");
}

int ReadInt(string argumentName)
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

TaskQuantity();