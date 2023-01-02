// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void TwoMatrixProduct()
{
    int m = ReadInt("number of rows in first matrix");
    int n = ReadInt("number of columns in first matrix and rows in second matrix");
    int p = ReadInt("number of columns in secons matrix");

    int[,] firstMatrix = GetTwoDimensionArray(m, n);
    int[,] secondMatrix = GetTwoDimensionArray(n, p);
    int[,] productMatrix = new int[m,p];

    PrintArray(firstMatrix);
    PrintArray(secondMatrix);

    FindTwoMatrixProduct(firstMatrix, secondMatrix, productMatrix);
    System.Console.WriteLine("The result matrix is:");
    PrintArray(productMatrix);
}

TwoMatrixProduct();


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

void FindTwoMatrixProduct(int[,] firstMatrix, int[,] secondMatrix, int[,] productMatrix)
{
    for (int i = 0; i < productMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < productMatrix.GetLength(1); j++)
        {
            int product = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                product += firstMatrix[i,k] * secondMatrix[k,j];
            }
            productMatrix[i,j] = product;
        }
    }
}
