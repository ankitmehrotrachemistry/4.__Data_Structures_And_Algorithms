using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSort
{
    class MatrixSortProgram
    {
        static int SIZE = 10;
        
        static void sortMat(int[,] mat, int n)
        {
            int[] temp = new int[n * n];
            int k = 0;
            
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    temp[k++] = mat[i, j];
            
            Array.Sort(temp);
            
            k = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    mat[i, j] = temp[k++];
        }
        
        static void printMat(int[,] mat, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(mat[i, j] + " ");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] mat = { { 5, 4, 7 },
                        { 1, 3, 8 },
                        { 2, 9, 6 } };
            int n = 3;

            Console.WriteLine("Original Matrix:");
            printMat(mat, n);

            sortMat(mat, n);

            Console.WriteLine("Matrix After Sorting:");
            printMat(mat, n);
        }
    }
}
