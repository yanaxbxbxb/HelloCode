﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели: ");
int a = int.Parse(Console.ReadLine());
if (a == 6 || a == 7 )
   {
    Console.WriteLine("Это выходной");
   } 

else if (a >= 1 && a <=5)
   {
   Console.WriteLine("Это не выходной");
   }
   
else 
    {
    Console.WriteLine("Дня недели с таким номером нет!");
    }