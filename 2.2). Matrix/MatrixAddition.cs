// C# Program to find Sum of 2 Matrix Mat1 and Mat2

using System;

namespace MatrixAddition
{
    class MatrixAdditionProgram
    {
        public static void Main(string[] args)
        {
            int row, col;

            Console.Write("Enter the number of Rows and Columns of Matrices A and B : ");

            row = Convert.ToInt16(Console.ReadLine());
            col = Convert.ToInt16(Console.ReadLine());

            int[,] Mat1 = new int[10,10];
            Console.Write("\nEnter the First Matrix : ");
            Console.WriteLine();
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    Mat1[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            int[,] Mat2 = new int[10, 10];
            Console.Write("\nEnter the Second Matrix : ");
            Console.WriteLine();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Mat2[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMatrix A is : ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(Mat1[i,j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatrix B is : ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(Mat2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int[,] SumOfMatrix = new int[10,10];
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    SumOfMatrix[i, j] = Mat1[i, j] + Mat2[i,j];
                }
            }

            Console.Write("\nSum of Mat1 and Mat2 is : ");
            Console.WriteLine();

            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    Console.Write(SumOfMatrix[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Enter the number of Rows and Columns of Matrices A and B : 2
2

Enter the First Matrix :
1
2
3
4

Enter the Second Matrix :
5
6
7
8

Matrix A is :
1       2
3       4

Matrix B is :
5       6
7       8

Sum of Mat1 and Mat2 is :
6       8
10      12

*/
