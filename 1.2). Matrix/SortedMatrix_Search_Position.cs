using System;

namespace SortedMatrix_Search_Position
{
    class Program
    {
        static int SearchInMatrix(int[,] matrix, int N, int elementToFind)
        {
            if (N == 0)
                return -1;

            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if (matrix[i,j] == elementToFind)
                    {
                        Console.Write("Element " + matrix[i,j] + " is found at (" + i + "," + j +") \n");
                        return 1;
                    }
                }
            }

            Console.Write("Element not found");

            return 0;
        }
        static void Main(string[] args)
        {
            int[,] matrix =  { { 10, 20, 30, 40 },
                   { 15, 25, 35, 45 },
                   { 27, 29, 37, 48 },
                   { 32, 33, 39, 50 } };

            SearchInMatrix(matrix, 4, 45);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Element 45 is found at (1,3)
*/
