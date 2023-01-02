//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void ReverseFromLeastToMost()
{
    int length1 = ReadInt("first length");
    int length2 = ReadInt("second length");

    int[,] array = GetTwoDimensionArray(length1, length2);
    PrintArray(array);

    SortEveryRow(array);
    PrintArray(array);
}

ReverseFromLeastToMost();

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
			array[i, j] = random.Next(100);
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

void SortRow(int[,] array, int row)
{
	for (int i = 0; i < array.GetLength(1); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			if (array[row, i] > array[row, j])
			{
				int temp = array[row, i];
				array[row, i] = array[row, j];
				array[row, j] = temp;
			}
		}
	}
}

void SortEveryRow(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		SortRow(array, i);
	}
}