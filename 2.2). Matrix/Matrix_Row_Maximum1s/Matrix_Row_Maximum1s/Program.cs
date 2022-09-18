using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Row_Maximum1s
{
    class Program
    {
        public static int R = 4, C = 4;
        public static int RowWithMaximumOne(int[][] matrix)
        {
            int max_row_index = 0;

            int i, index;
            index = C - 1;

            for (i = 0; i < R; i++)
            {
                if (index >= 0 && matrix[i][index] == 1)
                {
                    index -= 1;
                    max_row_index = i;
                }
            }

            if (max_row_index == 0 && matrix[0][C - 1] == 0)
                return 0;

            return max_row_index;
        }
        static void Main(string[] args)
        {
            int[][] mat = new int[][]
            {
                 new int[] {0, 0, 0, 1},
                 new int[] {0, 1, 1, 1},
                 new int[] {1, 1, 1, 1},
                 new int[] {0, 0, 0, 0}
            };

            Console.WriteLine("Index of Row with maximum 1 is : "+RowWithMaximumOne(mat));
        }
    }
}