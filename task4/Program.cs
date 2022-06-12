Console.Clear();
Console.Write("Введите трехзначное число N: ");
int N = Convert.ToInt32(ReadLine());
 if ((Math.Abs (N) < 100) || (Math.Abs (N) > 999)) {    
       Console.WriteLine("Введите не трехзначное число");
       return;
}
Console.WriteLine(N%10);

Console.WriteLine(N/10);
