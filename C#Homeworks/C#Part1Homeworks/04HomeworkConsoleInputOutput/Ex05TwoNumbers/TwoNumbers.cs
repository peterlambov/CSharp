//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements. 

using System;

class TwoNumbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double biggerNumber = a > b ? a : b;
            Console.WriteLine(biggerNumber);
        }
    }
