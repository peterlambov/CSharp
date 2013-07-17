
//Write a program that reads a number N and calculates the sum of the first N members of the sequence
//of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34..

using System;
class SumFibonacci
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        decimal firstMember = 0;
        decimal secondMember = 1;
        decimal sum = 0;
        for (int i = 1; i < N; i++)
        {
            decimal x = firstMember;
            firstMember = secondMember;
            secondMember = firstMember+x;
            sum += firstMember;
        }
        Console.WriteLine(sum);
        


    }
}

