//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixN
{
    static void PrintMatrix(int[,] matrix) //This is the method that we are going to use to print the matrices.
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
    static void Main()
    {
        // a)
        Console.WriteLine("This is the matrix a) , enter n:");
        int currentNumber = 1;
        int n = int.Parse(Console.ReadLine());
        
        int[,] matrix = new int[n, n];
        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            
            for (int row = 0; row < matrix.GetLength(1); row++)
            {

                matrix[row, col] = currentNumber;
                currentNumber++;
                  
            }
       
        }

        PrintMatrix(matrix);
        
        // b)
        Console.WriteLine("This is the matrix b) , enter n:");
        int value = 1;
        int n1 = int.Parse(Console.ReadLine());
       
        int[,] matrix1 = new int[n1, n1];

        for (int col = 0; col < matrix1.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n1; row++)
                {
                    matrix1[row, col] = value;
                    value++;


                }
            }
            else
            {
                for (int row = n1-1 ; row >= 0; row--)
                {
                    matrix1[row, col] = value;
                    value++;


                }
            }

        }

        PrintMatrix(matrix1);

        // c)
        Console.WriteLine("This is the matrix c) , enter n:");
        int n2 = int.Parse(Console.ReadLine());
        int[,] matrix2 = new int[n2, n2];
        int currentNumber1 = 1;
        int currentRow = matrix2.GetLength(0) - 1;
        int row2 = matrix2.GetLength(0) - 1;

       
        for (int col = 0; col <= matrix2.GetLength(1); col++)
        {
            col = 0;

            while (currentRow < matrix2.GetLength(0))
            {
                matrix2[currentRow, col] = currentNumber1;
                currentNumber1++;
                currentRow++;
                col++;
            }

            if (currentRow == matrix2.GetLength(0))
            {
                row2--;
                currentRow = row2;
            }
        }

        int currentCol = 1;
        int coll = 1;

        
       for (int i = 0; i < matrix2.GetLength(0); i++)
        {
           currentRow = 0;

            while (currentCol < matrix2.GetLength(1))
          {
                matrix2[currentRow, currentCol] = currentNumber1;
                currentNumber1++;
                currentCol++;
               currentRow++;
 }
            if (currentCol == matrix2.GetLength(1))
            {
                coll++;
                currentCol = coll;
           }
        }
        PrintMatrix(matrix2);
        // d)
        Console.WriteLine("This is the matrix d) , enter n:");
        int n4 = int.Parse(Console.ReadLine());
        int[,] matrix4 = new int[n4, n4];
        FillFourthMatrix(matrix4);
        PrintMatrix(matrix4);
    }
    static void FillFourthMatrix(int[,] matrix)
    {
        int currentNumber = 1;
        string[] directions = new string[] { "down", "right", "up", "left" };

        string currentDirection = directions[0];
        int currentRow = 0;
        int currentCol = 0;

        while (currentNumber <= matrix.GetLength(0) * matrix.GetLength(0))
        {
            if (currentDirection == "down")
            {
                while (currentRow < matrix.GetLength(0) && currentNumber <= matrix.GetLength(0) * matrix.GetLength(0))
                {
                    matrix[currentRow, currentCol] = currentNumber;
                    currentNumber++;
                    currentRow++;

                    if (currentRow == matrix.GetLength(0) || matrix[currentRow, currentCol] != 0)
                    {
                        currentDirection = directions[1];
                        currentRow--;
                        currentCol++;
                        break;
                    }
                }
            }

            if (currentDirection == "right")
            {
                while (currentCol < matrix.GetLength(1) && currentNumber <= matrix.GetLength(0) * matrix.GetLength(0))
                {
                    matrix[currentRow, currentCol] = currentNumber;
                    currentNumber++;
                    currentCol++;

                    if (currentCol == matrix.GetLength(1) || matrix[currentRow, currentCol] != 0)
                    {
                        currentDirection = directions[2];
                        currentCol--;
                        currentRow--;
                        break;
                    }
                }
            }

            if (currentDirection == "up")
            {
                while (currentRow >= 0 && currentNumber <= matrix.GetLength(0) * matrix.GetLength(0))
                {
                    matrix[currentRow, currentCol] = currentNumber;
                    currentNumber++;
                    currentRow--;

                    if (currentRow == -1 || matrix[currentRow, currentCol] != 0)
                    {
                        currentDirection = directions[3];
                        currentRow++;
                        currentCol--;
                        break;
                    }
                }
            }

            if (currentDirection == "left")
            {
                while (currentCol >= 0 && currentNumber <= matrix.GetLength(0) * matrix.GetLength(0))
                {
                    matrix[currentRow, currentCol] = currentNumber;
                    currentNumber++;
                    currentCol--;

                    if (currentCol == -1 || currentCol == 0 || matrix[currentRow, currentCol] != 0)
                    {
                        currentDirection = directions[0];
                        currentCol++;
                        currentRow++;
                        break;
                    }
                }
            }
        }
    }
}

