//Write a program that reads an integer number and calculates and prints its square root. 
//If the number is invalid or negative, print "Invalid number". 
//In all cases finally print "Good bye". Use try-catch-finally.
using System;
using System.Linq;
namespace Ex01SquareRoot
{
    class Square
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new IndexOutOfRangeException("Invalid number");
                }
                double squareRoot = Math.Sqrt(number);
                Console.WriteLine("The square root of {0} is {1}.", number, squareRoot);
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }

            catch (ArgumentNullException)
            {
               Console.WriteLine("Invalid number");
            }

            catch (OverflowException)
            {
                Console.WriteLine("Invalid number");
            }
            
            finally
            {
                Console.WriteLine("Good bye");
            }
            
        }
        
    }
}
