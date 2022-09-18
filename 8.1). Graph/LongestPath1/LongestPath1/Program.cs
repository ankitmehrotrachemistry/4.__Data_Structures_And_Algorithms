using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPath1
{
    class LongestPath1
    {

        static void DisplayPath(int[,] matrix, int maxCount)
        {
            List<Tuple<int, int>> path = new List<Tuple<int, int>>();
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int prevRow = rows;
            int prevCol = cols;
            for (int i = rows - 1; i >= 0; --i)
            {
                for (int j = cols - 1; j >= 0; --j)
                {
                    if (matrix[i, j] == maxCount && i <= prevRow && j <= prevCol)
                    {
                        path.Add(Tuple.Create(i, j));
                        maxCount--;
                        prevRow = i;
                        prevCol = j;
                    }

                    if (maxCount == 0)
                    {
                        Console.WriteLine("The path is ");
                        for (int k = path.Count() - 1; k >= 0; k--)
                        {
                            Console.WriteLine("{0}th -- [{1}, {2}]",
                                path.Count() - k, path[k].Item1, path[k].Item2);
                        }

                        return;
                    }
                }
            }
        }

        static int FindLongest1Sequences(int[,] matrix)
        {
            Contract.Requires(matrix != null);
            Contract.Requires(matrix.GetLength(0) > 0);
            Contract.Requires(matrix.GetLength(1) > 0);
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int maxCount = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int a = (i == 0) ? 0 : matrix[i - 1, j];
                    int b = (j == 0) ? 0 : matrix[i, j - 1];
                    matrix[i, j] = (matrix[i, j] == 1) ? Math.Max(a, b) + 1 : 0;
                    maxCount = Math.Max(maxCount, matrix[i, j]);
                }
            }

            DisplayPath(matrix, maxCount);

            return maxCount;
        }

        static void DoTest(int[,] matrix)
        {
            Contract.Requires(matrix != null);
            Contract.Requires(matrix.GetLength(0) > 0);
            Contract.Requires(matrix.GetLength(1) > 0);

            Console.WriteLine("The matrix is ");
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix.GetLength(1); ++j)
                {
                    Console.Write("{0, 3}", matrix[i, j]);
                }
                Console.WriteLine();
            }

            int len = FindLongest1Sequences(matrix);
            Console.WriteLine("The longest length is {0}", len);
            Console.WriteLine("------------------------------");

        }

        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5] {
                    {0, 0, 0, 1, 1},
                    {1, 1, 1, 0, 1},
                    {0, 1, 1, 1, 0},
                    {0, 0, 1, 0, 0},
                    {1, 1, 1, 1, 1}
                };

            DoTest(matrix);        // Expected return 8

            int[,] matrix1 = new int[1, 1]{
                    {0}
                };
            DoTest(matrix1);       // Expected return 0

            int[,] matrix2 = {
                    {1}
                };
            DoTest(matrix2);       // Expected return 1

            int[,] matrix3 = new int[5, 5];
            DoTest(matrix3);       // Expected return 0

            int[,] matrix4 = {
                    {1, 1, 1, 1, 1},
                    {1, 1, 1, 1, 1},
                    {1, 1, 1, 1, 1},
                    {1, 1, 1, 1, 1},
                    {1, 1, 1, 1, 1}
                };

            DoTest(matrix4);       // Expected return 9

            int[,] matrix5 = {
                    {1, 1, 0, 1, 1},
                    {0, 1, 1, 0, 1},
                    {1, 0, 0, 0, 0},
                    {1, 1, 0, 1, 1},
                    {1, 1, 1, 1, 1}
                };

            DoTest(matrix5);       // Expected return 7
        }
    }
}
