using System;

namespace MatrixSort
{
    class MatrixSortProgram
    {
        static void SortMatrix(int[,] matrix, int n)
        {
            int[] temp = new int[n*n];
            int k = 0;

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    temp[k++] = matrix[i,j];
                }
            }
            Array.Sort(temp);

            k = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = temp[k++];
                }
            }
        }

        static void printMatrix(int[,] matrix, int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] mat = { { 5, 4, 7 },
                        { 1, 3, 8 },
                        { 2, 9, 6 } };

            int N = 3;

            Console.WriteLine("Original Matrix is : ") ;
            printMatrix(mat, N);

            SortMatrix(mat, N);

            Console.WriteLine("Matrix after Sorting : ");
            printMatrix(mat, N);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Original Matrix is :
5 4 7
1 3 8
2 9 6
Matrix after Sorting :
1 2 3
4 5 6
7 8 9
*/
