using System;

namespace Sequential_Binary_Search
{
    internal class Program
    {
        public static int SequentialSearch(int[] arr, int size, int val)
        {
            for (int i = 0; i < size; i++)
            {
                if (val == arr[i])
                    return i;
            }
            return -1;
        }

        public static int BinarySearch(int[] arr, int size, int val)
        {
            int mid;
            int low = 0;
            int high = size - 1;

            while (low <= high)
            {
                mid = low + (high - low) / 2;

                if (arr[mid] == val)
                {
                    return mid;
                }
                else
                {
                    if (arr[mid] < val)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

            Console.WriteLine("The Element is at Index in SequentialSearch : " + SequentialSearch(arr, arr.Length, 70));
            Console.WriteLine("The Element is at Index in BinarySearch : " + BinarySearch(arr, arr.Length, 70));

            Console.ReadKey();
        }
    }
}
