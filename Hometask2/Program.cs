//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


Console.Clear();
{ 

{ double a, b, c, max;
Console.Write("a b c: ");
var s = Console.ReadLine().Split(" ");
a = Convert.ToDouble(s[0]);
b = Convert.ToDouble(s[1]);
c = Convert.ToDouble(s[2]);
max = Math.Max(a, Math.Max(b, c));
Console.WriteLine(max); } } 

