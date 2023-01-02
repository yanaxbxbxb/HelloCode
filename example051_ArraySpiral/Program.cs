// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void ArraySpiral()
{
    int n = 4;
    int[,] array = new int[n,n];
    int count = 1;
    int i = 0;
    int j = 0;
    while (count <= n*n)
    {
        array[i,j] = count;
        count++;
        if (i <= j+1 && i+j < n-1) {j++;}
        else if (i < j && i+j >= n-1) {i++;}
        else if (i >= j && i+j > n-1) {j--;}
        else i--;
    }

    PrintArray(array);
}

ArraySpiral();





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

