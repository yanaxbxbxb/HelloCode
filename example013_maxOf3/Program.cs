Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());
int max = 0;

if (a > b)
{
    if (a > c) max = a; 
    else if (c > a) max = c;
}

else if (b > a) 
{
    if (b > c) max = b;
    else if (c > b) max = c;
}

else if (c > a)
{
    if (c > b) max = c;
    else if (b > c) max = b;
}

Console.Write("max = ");
Console.WriteLine(max);