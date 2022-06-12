using System;
using static System.Console;

Console.Clear();
Console.WriteLine("Введите число a = ");
int a = Convert.ToInt32(ReadLine());
Console.WriteLine("Введите число b = ");
int b = Convert.ToInt32(ReadLine());

if ((a * a) == b) Console.WriteLine("Число b является квадратом числа a");
else                Console.WriteLine("Число b не является квадратом числа a");


