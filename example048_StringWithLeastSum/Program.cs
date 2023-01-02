// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void StringWithLeastSum()
{
    int length1 = ReadInt("first length");
    int length2 = ReadInt("second length");

    int[,] array = GetTwoDimensionArray(length1, length2);
    PrintArray(array);

    FindStringWithLeastSum(array);
}

StringWithLeastSum();

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

int FindSumInString(int[,] array, int i)
{
    int sum = array[i,0];
	for (int j = 1; j < array.GetLength(1); j++)
	{
        sum += array[i,j];
	}
    return sum;
}

void FindStringWithLeastSum(int[,] array)
{
    int stringNumber = 0;
    int sum = FindSumInString(array, 0);

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int temp = FindSumInString(array, i);
        if (sum > temp)
        {
            sum = temp;
            stringNumber = i;
        }
    }
    System.Console.WriteLine($"String with the least sum {sum} of elements is {stringNumber+1}");
}

