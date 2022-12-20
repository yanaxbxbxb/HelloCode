// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
void TaskFactorial()
{
    Console.WriteLine("TaskFactorial");
    int N = ReadInt("N");
    int factorial = Factorial(N);
    Console.WriteLine(factorial);
}

int ReadInt(string argumentName)
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

int Factorial(int N)
{
    int result = 1;
    for (int i = 1; i <= N; i++)
        {
            result = result * i;
        }
    return result;
}

TaskFactorial();
