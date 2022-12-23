﻿// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int length = ReadInt("Array length");
double[] array = GetRandomArray(length, 1, 10);

double max = FindMaxInArray(array);
double min = FindMinInArray(array);

PrintArray(array);
System.Console.WriteLine();
FindDiff(max, min);


int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine()!);
}

double[] GetRandomArray(int length, int minValue, int maxValue)
{
	double[] array = new double[length];
	Random random = new Random();

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = Math.Round(random.NextDouble() * (maxValue - minValue) + minValue, 2);  
	}

	return array;
}

void PrintArray(double[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]}, ");
	}
}

double FindMaxInArray(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) {max = array[i];}
    }
    return max;
}

double FindMinInArray(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) {min = array[i];}
    }
    return min;
}

void FindDiff(double max, double min)
{
    System.Console.WriteLine($"{max} - {min} = {Math.Round(max - min, 2)}");
}