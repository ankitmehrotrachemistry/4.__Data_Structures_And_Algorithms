using System;

namespace QuickSort_Recursive
{
    class Program
    {
        private static void quickSort(int[] arr, int lower, int upper)
        {
            if(upper <= lower)
            {
                return;
            }

            int pivot = arr[lower];
            int start = lower;
            int stop = upper;

            while(lower < upper)
            {
                while(arr[lower] <= pivot  && lower < upper)
                {
                    lower++;
                }

                while(arr[upper] > pivot  && lower <= upper)
                {
                    upper--;
                }

                if(lower < upper)
                {
                    swap(arr, upper, lower);
                }
            }

            swap(arr, upper, start);

            quickSort(arr, start, upper - 1);
            quickSort(arr, upper + 1, stop);
        }

        public static void sort(int[] arr)
        {
            int size = arr.Length;
            quickSort(arr, 0, size - 1);
        }
        private static void swap(int[] arr, int first, int second)
        {
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 1, 8, 2, 7, 3, 6, 4, 5 };

            Console.Write("The Array after Sorting using Quick Sort is : ");

            sort(array);

            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

            Console.ReadKey();
        }
    }
}

/*
INPUT
The Array after Sorting using Quick Sort is : 1 2 3 4 5 6 7 8 9
*/
