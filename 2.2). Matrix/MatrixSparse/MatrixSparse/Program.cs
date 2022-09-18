// C# Program to check whether 2D Matrix is Sparse or Not

// NOTE - A sparse matrix is a one in which the majority of the values are zero.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSparse
{
    class Program
    {
        static bool isSparse(int[,] array, int r, int c) // Boolean Condition to check Sparse Matrix
        {
            int count = 0;

            for (int i = 0; i < r; ++i)
            {
                for (int j = 0; j < c; ++j)
                {
                    if (array[i, j] == 0)
                    {
                        ++count;
                    }
                }
            }
            return (count > ((r*c)/2)); // Return boolean value 
        }

        static void Main(string[] args)
        {
            int[,] array = { {1,0,3}, {0,0,4}, {6,0,0}, {2,0,0}, {1,0,0} };

            int row = 5;
            int col = 3;

            if (isSparse(array, row, col))
                Console.WriteLine("Yes the Matrix is Sparse Matrix \n");
            else
                Console.WriteLine("No the Matrix is not a Sparse Matrix \n");
        }
    }
}
