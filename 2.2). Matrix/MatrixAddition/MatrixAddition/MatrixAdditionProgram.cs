// C# Program to find Sum of 2 Matrix M1 and M2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixAddition
{
    class MatrixAdditionProgram
    {
        public static void Main(string[] args)
        {
            int r, c, i, j;

            Console.Write("Enter Number Of Rows And Columns Of Matrices A and B : ");

            r = Convert.ToInt16(Console.ReadLine());
            c = Convert.ToInt16(Console.ReadLine());

            int[,] M1 = new int[10, 10];
            Console.Write("\nEnter The First Matrix : ");
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    M1[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            int[,] M2 = new int[10, 10];
            Console.Write("\nEnter The Second Matrix:");
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    M2[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            Console.Clear();

            Console.WriteLine("\nMatrix A : ");
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    Console.Write(M1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatrix B: ");
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    Console.Write(M2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int[,] C = new int[10, 10];
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    C[i, j] = M1[i, j] + M2[i, j];
                }
            }

            Console.Write("\nSum Matrix of M1 and M2 is :");
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    Console.Write(C[i, j] + "\t");

                }
                Console.WriteLine();
            }
            
        }
    }
}
