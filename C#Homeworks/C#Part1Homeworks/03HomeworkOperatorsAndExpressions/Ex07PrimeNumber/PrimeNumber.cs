// 07. Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
using System;
    class PrimeNumber
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            if (a > 100)
            {
                Console.WriteLine("Invalid input!");
            }
            
            else  if (a % 2 == 0 || a % 3 == 0 || a % 4 == 0 || a % 5 == 0 || a % 6 == 0 || a % 7 == 0|| (a*a) % a == 0)
            {
                Console.WriteLine("The number {0} is NOT prime", a);
            }
            else
            {
                Console.WriteLine("The number {0} is prime", a);
            }
        }
    }

