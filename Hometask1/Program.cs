//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


        {
            Console.WriteLine("Введите 2 числа и я подскажу какое из них больше");
            int a, b;
            Console.WriteLine("Введите первое число - ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число - ");
            b = Convert.ToInt32(Console.ReadLine());
 
            bool That0 = a > b;
            bool That1 = a == b;
            bool That2 = a < b;
 
            if (That0)
            {
                Console.WriteLine("a > b");
            }
            else if (That1)
            {
                Console.WriteLine("a = b");
            }
            else
            {
                Console.WriteLine("b > a");
            }
        }