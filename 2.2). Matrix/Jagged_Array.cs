using System;

namespace Jagged_Array
{
    class MyJaggedArray
    {
        static void Main(string[] args)
        {
            int[][] jagged_Array = new int[4][];

            jagged_Array[0] = new int[] {1, 2, 3, 4};
            jagged_Array[1] = new int[] {21, 1, 4 };
            jagged_Array[2] = new int[] {40, 10 };
            jagged_Array[3] = new int[] {5, 10, 15, 20, 25};

            Console.WriteLine("Jagged Array is : ");

            for (int n = 0; n < jagged_Array.Length; n++)
            {

                for(int k =0; k < jagged_Array[n].Length; k++)
                {
                    Console.Write(jagged_Array[n][k] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

/*
OUTPUT 
Jagged Array is :
1 2 3 4
21 1 4
40 10
5 10 15 20 25
*/
