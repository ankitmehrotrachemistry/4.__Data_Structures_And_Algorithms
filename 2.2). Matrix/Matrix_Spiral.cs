using System;

namespace Matrix_Spiral
{
    class Program
    {
        static void printSpiralMatrix(int row, int col, int[,] array)
        {
            int rowIndex = 0, colIndex = 0;

            while(rowIndex < row && colIndex < col)
            {
                for(int i = colIndex; i < col; i++)
                {
                    Console.Write(array[rowIndex, i] + " ");
                }
                rowIndex++;

                for(int i = rowIndex; i < row; i++)
                {
                    Console.Write(array[i, col - 1] + " ");
                }
                col--;

                if(rowIndex < row)
                {
                    for(int i = col - 1; i >= 1; i--)
                    {
                        Console.Write(array[row - 1, i] + " ");
                    }
                    row--;
                }
                if(colIndex < col)
                {
                    for(int i = row - 1; i >= rowIndex; i--)
                    {
                        Console.Write(array[i, colIndex] + " ");
                    }
                    colIndex++;
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

            Console.Write("The Spiral Matrix is : ");
            printSpiralMatrix(ROW, COL, arr);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
The Spiral Matrix is : 1 2 3 4 8 12 16 15 14 9 5 6 7 11 10
*/
