using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Maximum_Difference_Pair
{
    class Program
    {
        static int findMaximumValue(int N, int[,] mat)
        {
            int maxValue = int.MinValue;

            int[,] maxArr = new int[N, N];

            maxArr[N - 1, N - 1] = mat[N - 1, N - 1];

            int maxV = mat[N - 1, N - 1];
            for (int j = N - 2; j >= 0; j--)
            {
                if (mat[N - 1, j] > maxV)
                    maxV = mat[N - 1, j];
                maxArr[N - 1, j] = maxV;
            }

            maxV = mat[N - 1, N - 1];
            for (int i = N - 2; i >= 0; i--)
            {
                if (mat[i, N - 1] > maxV)
                    maxV = mat[i, N - 1];
                maxArr[i, N - 1] = maxV;
            }

            for (int i = N - 2; i >= 0; i--)
            {
                for (int j = N - 2; j >= 0; j--)
                {
                    if (maxArr[i + 1, j + 1] - mat[i, j] > maxValue)
                        maxValue = maxArr[i + 1, j + 1] - mat[i,j];

                    maxArr[i, j] = Math.Max(mat[i,j], Math.Max(maxArr[i,j+1], maxArr[i+1, j]));
                }
            }
            return maxValue;
        }
        static void Main(string[] args)
        {
            int N = 5;

            int[,] mat = {{ 1, 2, -1, -4, -20 },
                      { -8, -3, 4, 2, 1 },
                      { 3, 8, 6, 1, 3 },
                      { -4, -1, 1, 7, -6 },
                      { 0, -4, 10, -5, 1 }};

            Console.WriteLine("Maximum Value is : " +findMaximumValue(N, mat));
        }
    }
}