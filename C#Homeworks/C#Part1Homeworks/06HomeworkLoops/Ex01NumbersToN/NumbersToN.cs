//Write a program that prints all the numbers from 1 to N.
using System;
class NumbersToN
{
    static void Main()
    {
        Console.Write("Enter your number n:");
        int n = int.Parse(Console.ReadLine());
        int i = 1;
        while (i <= n)
        {

            Console.WriteLine(i);
            i++;
        }
    }
}


