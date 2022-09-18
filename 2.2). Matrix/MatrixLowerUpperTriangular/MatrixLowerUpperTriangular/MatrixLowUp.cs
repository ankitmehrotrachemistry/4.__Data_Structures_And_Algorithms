using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Find Upper and Lower Triangular Matrix Program in C#
// Visual Studio (Ctrl + F5) to run

namespace MatrixLowerUpperTriangular
{
    class MatrixLowUp
    {
        static void lower(int[,] matrix, int row, int col)
        {
            int i, j;
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    if (i < j)
                    {
                        Console.Write("0" + " ");
                    }
                    else
                        Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void upper(int[,] matrix, int row, int col)
        {
            int i, j;
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    if (i > j)
                    {
                        Console.Write("0" + " ");
                    }
                    else
                        Console.Write(matrix[i, j] + " ");
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

            Console.WriteLine("The Lower triangular matrix is :-");
            lower(matrix, row, col);

            Console.WriteLine("The Upper triangular matrix is :-");
            upper(matrix, row, col);
        }
    }
}
