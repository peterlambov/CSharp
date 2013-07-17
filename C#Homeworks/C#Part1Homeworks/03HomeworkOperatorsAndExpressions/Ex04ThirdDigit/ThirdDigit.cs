// 04. Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true.
using System;
    class ThirdDigit
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            bool b = ((Math.Abs(a / 100)) % 10 == 7);
            Console.WriteLine("The third digit of the number is seven: {0}",b);
            
            
        }
    }

