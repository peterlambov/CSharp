//Write a program that reads a text file containing a square matrix of numbers and finds 
//in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
//the first line in the input file contains the size of matrix n. each of the next n lines contain n numbers separated by space.
//the output should be a single number in a separate text file. 
using System;
using System.IO;
using System.Linq;
namespace Ex05MatrixFile
{
    class Matrix
    {
        static void Main()
        {
            StreamReader readMatrix = new StreamReader(@"..\..\theMatrix.txt");
            using (readMatrix)
            {
                int dimension = int.Parse(readMatrix.ReadLine());
                int[,] matrix = new int[dimension, dimension];
                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    string[] numbersOnLine=readMatrix.ReadLine().Split(' ');
                    for (int cols = 0; cols < matrix.GetLength(1); cols++)
                    {
                        matrix[rows, cols] = int.Parse(numbersOnLine[cols]);
                    }
                }
                int maximalSum = int.MinValue ;
                for (int rows = 0; rows < matrix.GetLength(0)-1; rows++)
                {
                    for (int cols = 0; cols < matrix.GetLength(1)-1; cols++)
                    {
                        maximalSum = Math.Max(maximalSum, matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows + 1, cols] + matrix[rows + 1, cols + 1]);
                    }
                }
                StreamWriter sum = new StreamWriter(@"..\..\sumFile.txt");
                using (sum)
                {
                    sum.WriteLine(maximalSum);
                }
                Console.WriteLine("Sum extracted and send to sumFile.txt, open it and see the result!");
                
            }
        }
    }
}
