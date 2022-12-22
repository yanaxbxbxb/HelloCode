// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

void PrintArray()
{
    int length = ReadInt("length");
    int[] array = GetArray(length);
    Console.Write(ArrayToString(array));
}


PrintArray();


int ReadInt(string argumentName)
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine()!);
}


int[] GetArray(int length)
{
	int[] array = new int[length];

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = ReadInt($"element {i}");
	}

	return array;
}


string ArrayToString(int[] array)
{
	string result = string.Empty;

	for (int i = 0; i < array.Length; i++)
	{
		result += $"{array[i]}, ";
	}
	return result;
}