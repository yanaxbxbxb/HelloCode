// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

int length = ReadInt("Array length");
int[] array = GetRandomArray(length, 1, 15);

PrintArray(array);
System.Console.WriteLine();
Product(array);


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


void Product(int[] array)
{
    for (int i=0; i < (array.Length/2); i++)
    {
        System.Console.Write($"{array[i]*array[length-i-1]}, ");
    }
    if (array.Length % 2 != 0)
    {
        System.Console.WriteLine(array[array.Length/2]);
    }
}
