// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void DoubleArraySizeMN()
{
    int M = ReadInt("M");
    int N = ReadInt("N");

    double[,] array = GetTwoDimensionArray(M, N, -10, 10);

    PrintArray(array);
}

DoubleArraySizeMN();

int ReadInt(string argument)
{
	Console.Write($"Input {argument}:");
	return int.Parse(Console.ReadLine()!);
}

double[,] GetTwoDimensionArray(int length1, int length2, int minValue, int maxValue)
{
	double[,] array = new double[length1, length2];
	Random random = new Random();

	for (int i = 0; i < length1; i++)
	{
		for (int j = 0; j < length2; j++)
		{
			array[i, j] = Math.Round(random.NextDouble() * (maxValue - minValue) + minValue, 2);
		}
	}
	return array;
}

void PrintArray(double[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write($"{array[i, j]} ");
		}
		Console.WriteLine();
	}
	Console.WriteLine();
}