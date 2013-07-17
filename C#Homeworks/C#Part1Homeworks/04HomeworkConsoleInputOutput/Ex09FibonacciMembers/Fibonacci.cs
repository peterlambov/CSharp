// Write a program to print the first 100 members of the sequence of
// Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
using System;
// Write a program to print the first 100 members of the sequence of
// Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377,...
    class Fibonacci
    {
        static void Main()
        {

            Console.WriteLine("Here are the first 100 Fibonacci members:");
            decimal a = 0; //This is the first member of the Fibonacci sequence
            decimal b = 1; //This is the second member
            for (decimal i = 0; i < 100; i++)
            {
                Console.WriteLine(a);
                decimal x = a; //Temporary variable
                a = b;
                b = a + x;
               
               
            }
            
           
            

            
           
            
        }

            
    }

