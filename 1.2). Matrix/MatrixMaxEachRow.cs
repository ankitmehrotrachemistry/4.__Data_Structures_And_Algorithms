using System;

namespace MatrixMaxEachRow
{
    class MatrixMax
    {
        public static void maxElement(int no_of_row, int[][] matrix)
        {
            int i = 0;
            int max = 0;

            int[] result = new int[no_of_row];

            while(i < no_of_row)
            {
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] > max)
                    {
                        max = matrix[i][j];
                    }
                }
                result[i] = max;
                max = 0;
                i++;
            }
            printArray(result);
        }

        private static void printArray(int[] result)
        {
            for(int i = 0; i < result.Length; i++)
            {
                //Console.Write(result[i]);

                string formattedString = string.Format("Row {0} max element is {1}", i, result[i]);
                Console.WriteLine(formattedString);
            }
        }
        static void Main(string[] args)
        {
            int[][] arr = new int[][]
            {
                new int[] {3, 4, 1, 8},
                new int[] {1, 4, 9, 11},
                new int[] {76, 34, 21, 1},
                new int[] {2, 1, 4, 5}
            };

            Console.WriteLine("Matrix Element in Matrix per row is : ");
            maxElement(4, arr);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Matrix Element in Matrix per row is :
Row 0 max element is 8
Row 1 max element is 11
Row 2 max element is 76
Row 3 max element is 5
*/
