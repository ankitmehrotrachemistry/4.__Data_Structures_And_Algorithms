using System;

namespace Zig_Zag
{
    class ZigZagProgram
    {
        static int largestZigZagSumRecursion(int[,] matrix, int i, int j, int n)
        {
            if (i == n - 1)
                return matrix[i,j];

            int ZigZagSum = 0;

            for (int k = 0; k < n; k++)
                if (k != j)
                    ZigZagSum = Math.Max(ZigZagSum, largestZigZagSumRecursion(matrix, i + 1, k, n));


            return ZigZagSum + matrix[i,j];
        }

        static int largestZigZag(int[,] matrix , int n)
        {
            int res = 0;

            for (int j = 0; j < n; j++)
                res = Math.Max(res, largestZigZagSumRecursion(matrix, 0, j, n));

            return res;
        }
        public static void Main()
        {
            int n = 3;
            int[,] mat = {{4, 2, 1},
                          {3, 9, 6},
                          {11, 3, 15}};

            Console.WriteLine("Largest Zig Zag Sum : " + largestZigZag(mat, n));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Largest Zig Zag Sum : 28
*/
