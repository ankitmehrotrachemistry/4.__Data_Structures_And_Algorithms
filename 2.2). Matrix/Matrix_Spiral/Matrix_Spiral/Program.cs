using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Spiral
{
    class Program
    {
        static void printSpiralMatrix(int row, int col, int[,] a)
        {
            int i;
            int k = 0, l = 0;

            while (k < row && l < col)
            {
                for (i = l; i < col; ++i)
                {
                    Console.Write(a[k,i] + " ");
                }
                k++;

                for (i = k; i < row; ++i)
                {
                    Console.Write(a[i, col - 1] + " ");
                }
                col--;

                if (k < row)
                {
                    for (i = col - 1; i >= l; --i)
                    {
                        Console.Write(a[row - 1, i] + " ");
                    }
                    row--;
                }

                if (l < col)
                {
                    for (i = row - 1; i >= k; --i)
                    {
                        Console.Write(a[i,l]+ " ");
                    }
                    l++;
                }
            }
        }
        static void Main(string[] args)
        {
            int ROW = 4;
            int COL = 4;

            int[,] arr = {{1, 2, 3, 4},
                   {5, 6, 7, 8},
                   {9, 10, 11, 12},
                   {13, 14, 15, 16}};

            printSpiralMatrix(ROW,COL,arr);
        }
    }
}
