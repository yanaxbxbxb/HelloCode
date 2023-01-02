// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FindElementOnPosition()
{
    int length1 = ReadInt("first length");
    int length2 = ReadInt("second length");

    int[,] array = GetTwoDimensionArray(length1, length2);
    PrintArray(array);

    int stringPosition = ReadInt("string number");
    int rowPosition = ReadInt("row number");

    ElementOnPosition(array, stringPosition, rowPosition);
}

FindElementOnPosition();


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

void ElementOnPosition(int[,] array, int stringPosition, int rowPosition)
{
    if (stringPosition < array.GetLength(0) && rowPosition < array.GetLength(1))
    {
        Console.Write(array[stringPosition, rowPosition]);
    }
    else Console.Write("There is no element on this position");
}