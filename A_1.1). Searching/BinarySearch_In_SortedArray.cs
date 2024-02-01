using System;

namespace BinarySearch_In_SortedArray
{
    class Program
    {
        // Binary Search Method
        public static int firstIndex(int[] arr, int size, int low, int high, int value)
        {
            int mid = 0;

            if(high >= low)
            {
                mid = (low + high) / 2;
            }

            if((mid == 0 || arr[mid - 1] < value)  &&  (arr[mid] == value))
            {
                return mid;
            }

            else if(arr[mid] < value)
            {
                return firstIndex(arr, size, mid + 1, high, value);
            }

            else
            {
                return firstIndex(arr, size, low, mid - 1, value);
            }
        }

        public static bool isMajority(int[] arr, int size)
        {
            int majority = arr[size/2];

            int i = firstIndex(arr, size, 0, size - 1, majority);

            if((i + size/2) <= (size - 1) && arr[i + size/2] == majority)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 3, 3, 3, 4, 5, 10 };

            Console.Write("Is there Majority Element in Array ? " + isMajority(arr, arr.Length));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Is there Majority Element in Array ? True
*/
