// Find Upper and Lower Triangular Matrix Program in C#

using System;

namespace MatrixLowerUpperTriangular
{
    class MatrixLowUp
    {
        static void LowerMatrix(int[,] matrix, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i > j)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write("0" + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void UpperMatrix(int[,] matrix, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if(i > j)
                    {
                        Console.Write("0" + " ");
                    }
                    else
                    {
                        Console.Write(matrix[i,j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] matrix = {{1, 4, 5, 5},
                        {6, 7, 8, 4},
                        {3, 4, 7, 2},
                        {1, 3, 6, 8}};

            int row = 4, col = 4;

            Console.WriteLine("The Lower Triangular Matrix is :");
            LowerMatrix(matrix, row, col);

            Console.WriteLine("The Upper Triangular Matrix is :");
            UpperMatrix(matrix, row, col);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
The Lower Triangular Matrix is :
0 0 0 0
6 0 0 0
3 4 0 0
1 3 6 0
The Upper Triangular Matrix is :
1 4 5 5
0 7 8 4
0 0 7 2
0 0 0 8
*/
