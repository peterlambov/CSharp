//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix .

using System;

    class Matrix
    {
        static void Main()
        
        {
            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());
            if (n > 20 || n < 1)
            {
                Console.WriteLine("You number mustn't be greater than 20 or smaller than 1.");
            }
            else
            {
                for (int row = 1; row <= n; row++)
                {
                    for (int col = row; col <= row + n - 1; col++)
                    {
                        Console.Write(col + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
