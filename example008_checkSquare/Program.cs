int i = int.Parse(Console.ReadLine());

if (int.TryParse(Console.ReadLine(), out int j))
{
    if (i == Math.Pow(j, 2))
    {
        Console.WriteLine($"Число {i} является квадратом числа {j}");
    }
    else
    {
        Console.WriteLine($"Число {i} не является квадратом числа {j}");
    }
}
else
{
    Console.WriteLine($"Это не число!");
}