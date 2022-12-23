// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int length = ReadInt("Array length");
int[] array = GetRandomArray(length, -100, 100);

PrintArray(array);
Search(array, ReadInt("Число, которое пользователь хочет найти"));
System.Console.WriteLine();


int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine()!);
}

int[] GetRandomArray(int length, int minValue, int maxValue)
{
	int[] array = new int[length];
	Random random = new Random();

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = random.Next(minValue, maxValue + 1);
	}

	return array;
}


void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]}, ");
	}
}

void Search(int[] array, int x)    
{
    for (int i = 0; i < array.Length; i++)
	{
		if (x==array[i])
        {
            Console.WriteLine("YES");
            return;
        }
	}
    System.Console.WriteLine("NO");
}
