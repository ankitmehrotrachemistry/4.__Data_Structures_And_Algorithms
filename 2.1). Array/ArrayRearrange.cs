// Rearrange the array such that A[i] = i, and if i is not present, display -1 at that place.

using System;

namespace ArrayRearrange
{
    class Program
    {
        static void fixArray(int[] arr, int n)
        {
            int i, j, temp;

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (arr[j] == i)
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;

                        break;
                    }
                }
            }

            for (i = 0; i < n; i++)
            {
                if (arr[i] != i)
                {
                    arr[i] = -1;
                }
            }

            Console.WriteLine("Array after rearranging");

            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { -1, -1, 6, 1, 9, 3, 2, -1, 4, -1 };

            int n = arr.Length;

            fixArray(arr, n);

            Console.ReadKey();
        }
    }
}
/*
OUTPUT
Array after rearranging
-1 1 2 3 4 -1 6 -1 -1 9
*/
