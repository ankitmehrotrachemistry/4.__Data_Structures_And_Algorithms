// Rearrange the array such that A[i] = i, and if i is not present, display -1 at that place.

using System;

namespace IndexArray_MinusOne
{
    internal class Program
    {
        public static void IndexArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                int curr = i;
                int value = -1;

                while (arr[curr] != -1 && arr[curr] != curr)
                {
                    int temp = arr[curr];
                    arr[curr] = value;
                    value = curr = temp;
                }

                if (value != -1)
                {
                    arr[curr] = value;
                }
            }
        }
        public static void PrintArray(int[] array, int length)
        {
            Console.WriteLine("Rearrange the array such that A[i] = i or display -1 : ");

            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arrayIndex = new int[] { 8, -1, 6, 1, 9, 3, 2, 7, 4, -1 };

            int size = arrayIndex.Length;

            IndexArray(arrayIndex, size);

            PrintArray(arrayIndex, size);

            Console.ReadKey();
        }
    }
}
/*
INPUT
Rearrange the array such that A[i] = i or display -1 :
-1 1 2 3 4 -1 6 7 8 9
*/
