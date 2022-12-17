Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int count = 1;
while (count <= a)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count} ");
    }
     count = count + 1;
}