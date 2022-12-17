Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int max = 0;

if (a > b) max = a;
else if (b > a) max = b;

Console.Write("max = ");
Console.WriteLine(max);