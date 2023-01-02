// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void ThreeDimentoinalArrayWithIndex()
{
    System.Console.WriteLine("Input x, y, z for massive size");
    int x = ReadInt("x");
    int y = ReadInt("y");
    int z = ReadInt("z");

    int [,,] array = GetThreeDimensionArray(x, y, z);
    PrintArray3D(array);
}

ThreeDimentoinalArrayWithIndex();



int ReadInt(string argument)
{
	Console.Write($"Input {argument}:");
	return int.Parse(Console.ReadLine()!);
}

int[,,] GetThreeDimensionArray(int length1, int length2, int length3)
{
	int[,,] array = new int[length1, length2, length3];
	Random random = new Random();

	for (int i = 0; i < length1; i++)
	{
		for (int j = 0; j < length2; j++)
        {
            for (int k = 0; k < length3; k++)
            {
                array[i, j, k] = random.Next(100);
            }
        }
	}
    return array;
}
	
void PrintArray3D(int[,,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
		Console.WriteLine();
	}
	Console.WriteLine();
}
