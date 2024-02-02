using System;

namespace BubbleSort
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

            int temp;

            for(int i = 0; i < size - 1; i++)
            {
                for(int j = 0; j < size - i -1; j++)
                {
                    if( more(arr[j], arr[j + 1]) )
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 1, 8, 2, 7, 3, 6, 4, 5};

            Console.Write("The Array after Sorting using Bubble Sort is : ");

            sort(array);

            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
The Array after Sorting using Bubble Sort is : 1 2 3 4 5 6 7 8 9
*/
