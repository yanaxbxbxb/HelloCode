// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void TaskArray()
{
    Console.WriteLine("TaskArray");
    int size = ReadInt("size");
    int[] Array = GetArray(size);
    Console.WriteLine(ArrayToString(Array));
    int[] GetArray(int size)
{
	int[] array = new int[size];

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(0,2);
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
}

int ReadInt(string argumentName)
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

TaskArray();
