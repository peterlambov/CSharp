using System;
using System.Linq;


public class MatrixGeneric<T>
    where T:IComparable
   
{
    private T[,] matrix;
    public readonly int rows;
    public readonly int cols;

    public MatrixGeneric(int rows, int cols)
    {
        this.Cols = cols;
        this.Rows = rows;
        this.matrix = new T[rows, cols];
    }

    public int Rows
    {
        get { return this.rows; }
        set { this.Rows = rows; }
    }

    public int Cols
    {
        get { return this.cols; }
        set { this.Cols = cols; }
    }

    public T this[int row,int col]
    {
        get
        {
            if (row >= this.rows || row < 0 ||col >= this.cols || col < 0)
            {
                throw new IndexOutOfRangeException();
            }
            T result = matrix[row,col];
            return result;
        }
        set
        {
            if (row < 0 || col < 0 || row >= this.Rows || col >= this.Cols)
            {
                throw new IndexOutOfRangeException("Out of the matrix!");
            }

            this.matrix[row, col] = value;
        }
    }

    public static MatrixGeneric<T> operator -(MatrixGeneric<T> firstMatrix, MatrixGeneric<T> secondMatrix)
    {
        MatrixGeneric<T> resultMatrix = new MatrixGeneric<T>(firstMatrix.Rows, firstMatrix.Cols); 
        if (firstMatrix.Rows==secondMatrix.Cols && firstMatrix.Cols == secondMatrix.Cols)
        {
            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    dynamic firstElement = firstMatrix[i, j];
                    dynamic secondElement = secondMatrix[i, j];
                    resultMatrix[i, j] = firstElement - secondElement;
                }
            } 
        }
        else
        {
            throw new InvalidOperationException("The sizes of the matrixes are not the same!");
        }
        return resultMatrix;
    }

    public static MatrixGeneric<T> operator +(MatrixGeneric<T> firstMatrix, MatrixGeneric<T> secondMatrix)
    {
        MatrixGeneric<T> resultMatrix = new MatrixGeneric<T>(firstMatrix.Rows, firstMatrix.Cols);
        if (firstMatrix.Rows == secondMatrix.Cols && firstMatrix.Cols == secondMatrix.Cols)
        {
            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    dynamic firstElement = firstMatrix[i, j];
                    dynamic secondElement = secondMatrix[i, j];
                    resultMatrix[i, j] = firstElement + secondElement;
                }
            }
        }
        else
        {
            throw new InvalidOperationException("The sizes of the matrixes are not the same!");
        }
        return resultMatrix;
    }

    public static MatrixGeneric<T> operator *(MatrixGeneric<T> firstMatrix, MatrixGeneric<T> secondMatrix)
    {
        MatrixGeneric<T> resultMatrix = new MatrixGeneric<T>(firstMatrix.Rows, firstMatrix.Cols);
        if (firstMatrix.Rows == secondMatrix.Cols && firstMatrix.Cols == secondMatrix.Cols)
        {
            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    for (int k = 0; k < firstMatrix.Cols; k++)
                    {
                        for (int l = 0; l < firstMatrix.Cols; l++)
                        {
                            dynamic firstElement = firstMatrix[i, j];
                            dynamic secondElement = secondMatrix[i, j];
                            resultMatrix[i, j] += firstElement * secondElement;
                        }
                    }
                  
                }
            }
        }
        else
        {
            throw new InvalidOperationException("The sizes of the matrixes are not the same!");
        }

        return resultMatrix;
    }

    public static bool operator true(MatrixGeneric<T> matrix)
    {
        if (matrix == null || matrix.Rows == 0 || matrix.Cols == 0)
        {
            return false;
        }

        for (int row = 0; row < matrix.Rows; row++)
        {
            for (int col = 0; col < matrix.Cols; col++)
            {
                if (!matrix[row, col].Equals(default(T)))
                {
                    return true;
                }
            }
        }

        return false;
    }

    public static bool operator false(MatrixGeneric<T> matrix)
    {
        if (matrix == null || matrix.Rows == 0 || matrix.Cols == 0)
        {
            return true;
        }

        for (int row = 0; row < matrix.Rows; row++)
        {
            for (int col = 0; col < matrix.Cols; col++)
            {
                if (!matrix[row, col].Equals(default(T)))
                {
                    return false;
                }
            }
        }

        return true;
    }
}

