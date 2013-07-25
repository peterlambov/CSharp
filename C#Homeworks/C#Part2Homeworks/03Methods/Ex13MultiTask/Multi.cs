//Write a program that can solve these tasks:
//Reverses the digits of a number
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
using System;
using System.Linq;

namespace Ex12MultiTask
{
    class Multi
    {
        static void Main()
        {
            Console.WriteLine("Hello, you have 3 subprograms to choose from:");
            Console.WriteLine("Enter 1 if you want to reverse a number.");
            Console.WriteLine("Enter 2 if you want to get an average of a sequence.");
            Console.WriteLine("Enter 3 if you want to solve a linear equation.");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the number that you want to be reversed:");
                    int number = int.Parse(Console.ReadLine());
                    ReverseNumber(number);
                    break;
                case 2:
                    Console.WriteLine("Enter the number of elements of your sequence:");
                    int n = int.Parse(Console.ReadLine());
                    int[] array = new int[n];
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = int.Parse(Console.ReadLine());
                    }
                    Average(n, array);
                    break;
                case 3:
                    Console.WriteLine("Enter the coefficients a and b on a separate line:");
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    LinearEquation(a, b);
                    break;
                default:
                    break;
            }
        }

        static void ReverseNumber(int number)
        {
            int result = 0;
            if (number < 0)
            {
                Console.WriteLine("Negative number!");
            }
            else
            {
                while (number > 0)
                {
                    result = result * 10 + number % 10;
                    number = number / 10;
                }
                Console.WriteLine("Your reversed number is: {0}.", result);
            }
        }

        static void Average(int numElements, int[] array)
        {
            if (numElements == 0)
            {
                Console.WriteLine("Empty sequence!");
            }
            else
            {
                double sum = 0;
                double average = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                average = sum / array.Length;
                Console.WriteLine("The average of your sequence is: {0}.", average);
            }
        }

        static void LinearEquation(double a, double b)
        {
            if (a == 0)
            {
                Console.WriteLine("Invalid coefficient a !");
            }
            else
            {
                double result = (b * (-1)) / a;
                Console.WriteLine("This is the root of your equation: {0}.", result);
            }
        }
    }
}

