//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.
using System;
using System.Linq;
using System.Numerics;

namespace Ex13MethodsForSequence
{
    class MultiSequence
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of elements of the sequence:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Minimum(array);
            Maximum(array);
            Average(array);
            Sum(array);
            Product(array);
        }

        static void Average(int[] array)
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

        static void Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            Console.WriteLine("The sum of the sequence is: {0}.", sum);
        }

        static void Minimum(int[] array)
        {
            int minNumber = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minNumber)
                {
                    minNumber = array[i];
                }
            }
            Console.WriteLine("The minimal element in the sequence is: {0}.", minNumber);
        }

        static void Maximum(int[] array)
        {
            int maxNumber = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxNumber)
                {
                    maxNumber = array[i];
                }
            }
            Console.WriteLine("The maximal element in the sequence is: {0}.", maxNumber);
        }

        static void Product(int[] array)
        {
            BigInteger product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product = product * array[i];
            }
            Console.WriteLine("The product of the sequence is: {0}.", product);
        }
    }
}

