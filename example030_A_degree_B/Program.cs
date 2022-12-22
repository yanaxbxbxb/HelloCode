// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void A_degree_B()
{
    int A = ReadInt("A");
    int B = ReadInt("B");

    int result = A_deg_B(A, B);
    Console.Write($"Number {A} in the power of {B} is {result}");
}

A_degree_B();

int ReadInt(string argumentName)
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine()!);
}

int A_deg_B(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result = result * A;
    }
    return result;
}

