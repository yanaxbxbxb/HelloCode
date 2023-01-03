// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumOfElementsFromMtoN(int M, int N)
{
    if (M>=N)
    {
        return M;
    }
    return M + SumOfElementsFromMtoN(M+1, N);
}

System.Console.Write(SumOfElementsFromMtoN(1, 15));