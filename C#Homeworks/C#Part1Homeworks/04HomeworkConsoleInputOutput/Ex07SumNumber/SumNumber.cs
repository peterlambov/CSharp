﻿
//Write a program that gets a number n
//and after that gets more n numbers
//and calculates and prints their sum.
using System;

namespace Ex07SumNumber
{
    class SumNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
            sum += numbers;
            }
            Console.WriteLine("The sum of the numbers is : {0}",sum);
        }
    }
}
