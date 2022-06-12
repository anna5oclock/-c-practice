//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8
using System;
using static System.Console;
Console.Clear();
  Console.Write("Write number 1: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Write number 2: ");
        int m = int.Parse(Console.ReadLine());
        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
        Console.ReadKey();
    
