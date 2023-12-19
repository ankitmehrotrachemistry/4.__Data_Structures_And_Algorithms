// C# Program to check whether 2D Matrix is Sparse or Not
// NOTE - A sparse matrix is a one in which the majority of the values are zero.

using System;

namespace MatrixSparse
{
    class Program
    {
        static bool isSparse(int[,] array, int row, int col)
        {
            int count = 0;

            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    if (array[i,j] == 0)
                    {
                        count++;
                    }
                }
            }
            return (count > ((row * col) / 2));
        }
        static void Main(string[] args)
        {
            int[,] array = { { 1, 0, 3 }, { 0, 0, 4 }, { 6, 0, 0 }, { 2, 0, 0 }, { 1, 0, 0 } };

            int row = 5;
            int col = 3;

            if (isSparse(array, row, col))
                Console.WriteLine("Yes, the matrix is Sparse Matrix");
            else
                Console.WriteLine("No, the matrix is Sparse Matrix");

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Yes, the matrix is Sparse Matrix
*/
