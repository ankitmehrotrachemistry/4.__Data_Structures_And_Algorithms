using System;

namespace Matrix_Row_Maximum1s
{
    class Program
    {
        public static int ROW = 4, COL = 4;

        public static int RowWithMaximumOne(int[][] matrix)
        {
            int max_row_index = 0;

            int index;
            index = COL - 1;

            for(int i = 0; i < ROW; i++)
            {
                if(index >= 0 && matrix[i][index] == 1)
                {
                    index -= 1;
                    max_row_index = i;
                }
            }

            if (max_row_index == 0 && matrix[0][COL - 1] == 0)
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

            Console.WriteLine("Index of Row with maximum 1 is : " + RowWithMaximumOne(mat));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Index of Row with maximum 1 is : 2
*/
