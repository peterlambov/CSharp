// 02. Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
using System;
    class DivisionToSevenAndFive
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine()); //You can try by typing 35
            bool b = (a % 5 == 0 && a % 7 == 0);
            Console.WriteLine(b);
        }
    }

