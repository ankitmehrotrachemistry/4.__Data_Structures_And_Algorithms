using System;

namespace InsertionSort
{
    class Program
    {
        private static bool more(int value1, int value2)
        {
            return value1 > value2;
        }

        public static void sort(int[] arr)
        {
            int size = arr.Length;

            int j, temp;

            for(int i = 1; i < size; i++)
            {
                temp = arr[i];

                for(j = i; j > 0 && more(arr[j - 1], temp); j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[j] = temp;
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 1, 8, 2, 7, 3, 6, 4, 5};

            Console.Write("The Array after Sorting using Insertion Sort is : ");

            sort(array);

            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

            Console.ReadKey();
        }
    }
}

/*
INPUT
The Array after Sorting using Insertion Sort is : 1 2 3 4 5 6 7 8 9
*/
