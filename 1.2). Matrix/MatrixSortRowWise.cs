using System;

namespace MatrixSortRowWise
{
    class MatrixSortRow
    {
        static int SortMatrix(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++) // GetLength(0) specify number of Rows
            {
                for(int j =0; j < matrix.GetLength(1); j++) // GetLength(1) specify number of Columns
                {
                    for(int k = 0; k < matrix.GetLength(1) - j - 1; k++)
                    {
                        if (matrix[i,k] > matrix[i, k+1])
                        {
                            int t = matrix[i,k];
                            matrix[i, k] = matrix[i, k+1];
                            matrix[i, k + 1] = t;
                        }
                    }
                }
            }

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + " ");
                    Console.WriteLine();
            }

            return 0;
        }
        static void Main(string[] args)
        {
            int[,] matrix = {{ 9, 8, 7, 1 },
                { 7, 3, 0, 2 },
                { 9, 5, 3, 2 },
                { 6, 3, 1, 2 }};

            Console.WriteLine("Matrix after sorting it row wise is : ");

            SortMatrix(matrix);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Matrix after sorting it row wise is :
1 7 8 9
0 2 3 7
2 3 5 9
1 2 3 6
*/
