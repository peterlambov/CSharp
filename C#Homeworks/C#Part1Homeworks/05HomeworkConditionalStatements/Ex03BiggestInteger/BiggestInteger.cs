//Write a program that finds the biggest of three integers using nested if statements.

using System;

    class BiggestInteger
    {
        static void Main()
        {
            Console.WriteLine("Enter three numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.Write("The biggest number is: ");
            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }

