//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements 
//located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class LongestSequence
    {
        static void Main()
        {
            string[,] matrix = new string[,]{{"op","op","xx","ha"},
                                             {"xx","xx","ha","xx"},
                                             {"hi","ha","hi","op"},
                                             {"hv","xx","hi","op"},
                                           };

            string bestElement = "";
            int bestSequence = 1;
            //Horizontally
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int currentSequence = 1;
                    string currentElement = matrix[row, col];
                    while (col<matrix.GetLength(1)-1&&matrix[row,col]==matrix[row,col+1])
                    {
                        currentSequence++;
                        col++;
                    }
                    if (currentSequence > bestSequence)
                    {
                        bestSequence = currentSequence;
                        bestElement = currentElement;
                    }
                }
            }
            //Vertically
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row= 0;  row < matrix.GetLength(0); row++)
                {
                    int currentSequence = 1;
                    string currentElement = matrix[row, col];
                    while (row < matrix.GetLength(0) - 1 && matrix[row, col] == matrix[row + 1, col])
                    {
                        currentSequence++;
                        row++;
                    }
                    if(currentSequence>bestSequence)
                    {
                        bestSequence = currentSequence;
                        bestElement = currentElement;
                    }
                }
            }
            //The "first" diagonals
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int currentSequence = 1;
                    string currentElement = matrix[row, col];
                    while (row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1 && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        currentSequence++;
                        row++;
                        col++;
                    }
                    if (currentSequence > bestSequence)
                    {
                        bestSequence = currentSequence;
                        bestElement = currentElement;
                    }
                }
            }
            //The "second" diagonals
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = matrix.GetLength(1)-1; col >0 ; col--)
                {
                    int currentSequence = 1;
                    string currentElement = matrix[row, col];
                    while (row < matrix.GetLength(0) - 1 && col > 0 && matrix[row, col] == matrix[row + 1, col - 1])
                    {
                        currentSequence++;
                        row++;
                        col--;
                    }
                    if (currentSequence > bestSequence)
                    {
                        bestSequence = currentSequence;
                        bestElement = currentElement;
                    }
                }
            }
            Console.WriteLine("Here is the printed matrix:");
            PrintMatrix(matrix);
            Console.WriteLine(@"The longest sequence consist of {0} elements of type ""{1}"".",bestSequence,bestElement);
        }
        static void PrintMatrix(string[,] matrix) 
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0, 5}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

    }

