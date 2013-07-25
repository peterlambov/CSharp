//Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 
using System;
using System.Linq;
using System.Numerics;


    class NFac
    {
        static void Main()
        {
            //Console.WriteLine(Factorial(5)); This row prints only the factorial of 5 or any number you want.
            //This loop prints the factorials of each number from 1 to 100.
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(Factorial(i));
            }
        }
        static BigInteger Factorial(BigInteger number)
        {
            BigInteger productN = 1;
            for (int i = 1; i <=number ; i++)
            {
                productN *= i;
            }
            return productN;
        }
    }

