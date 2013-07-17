// 01. Write an expression that checks if given integer is odd or even.
using System;


    class OddEven
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            bool b = (a % 2 == 0);
            Console.Write("The number {0} is even: ",a);
            Console.WriteLine(b);
        }
    }

