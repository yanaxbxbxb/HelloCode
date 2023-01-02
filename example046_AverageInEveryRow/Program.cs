// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void AverageInEveryRow()
{
    int length1 = ReadInt("first length");
    int length2 = ReadInt("second length");

    int[,] array = GetTwoDimensionArray(length1, length2);
    PrintArray(array);

    FindAverageInEveryRow(array);
}

AverageInEveryRow();


int ReadInt(string argument)
{
	Console.Write($"Input {argument}:");
	return int.Parse(Console.ReadLine()!);
}

int[,] GetTwoDimensionArray(int length1, int length2)
{
	int[,] array = new int[length1, length2];
	Random random = new Random();

	for (int i = 0; i < length1; i++)
	{
		for (int j = 0; j < length2; j++)
		{
			array[i, j] = random.Next(10);
		}
	}
	return array;
}

void PrintArray(int[,] array)
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

void FindAverageInEveryRow(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        double average = 0;
        average = Math.Round(sum/array.GetLength(0), 1);
        System.Console.Write($"{average}; ");
    }
}