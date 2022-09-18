using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSortRowWise
{
    class MatrixSortRow
    {
        static int sortRowWise(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++) // GetLength(0) specify number of Rows
            {
                for (int j = 0; j < m.GetLength(1); j++) // GetLength(1) specify number of Columns
                {
                    for (int k = 0; k < m.GetLength(1) - j - 1; k++)
                    {
                        if (m[i, k] > m[i, k + 1])
                        {
                            int t = m[i, k];
                            m[i, k] = m[i, k + 1];
                            m[i, k + 1] = t;
                        }
                    }
                }
            }
            
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                    Console.Write(m[i, j] + " ");
                    Console.WriteLine();
            }
            return 0;
        }

        static void Main(string[] args)
        {
            int[,] m = {{ 9, 8, 7, 1 },
                { 7, 3, 0, 2 },
                { 9, 5, 3, 2 },
                { 6, 3, 1, 2 }};
            sortRowWise(m);
        }
    }
}
