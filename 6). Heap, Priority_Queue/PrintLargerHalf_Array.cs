using System;

namespace PrintLargerHalf_Array
{
    class Program
    {
        public static void PrintLargerHalf(int[] arr, int size)
        {
            Array.Sort(arr);

            for(int i = size/2; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 8, 7, 6, 5, 7, 3, 2, 1 };

            Console.Write("Larger Half of Array is : ");

            PrintLargerHalf(arr, 8);

            Console.ReadKey();
        }
    }
}
/*
OUTPUT
Larger Half of Array is : 6 7 7 8
*/
