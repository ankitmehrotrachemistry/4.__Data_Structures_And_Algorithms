using System;

namespace binarySearchRecursion
{
    class Program
    {
        public static bool BinarySearchRec(int[] arr, int size, int value)
        {
            int low = 0;
            int high = size - 1;

            return BinarySearchRecUtil(arr, low, high, value);
        }

        public static bool BinarySearchRecUtil(int[] arr, int low, int high, int value)
        {
            if(low > high)
            {
                return false;
            }

            int mid = (low + high) / 2;

            if(arr[mid] == value)
            {
                return true;
            }
            else if(arr[mid] < value)
            {
                return BinarySearchRecUtil(arr, mid + 1, high, value);
            }
            else
            {
                return BinarySearchRecUtil(arr, low, mid - 1, value);
            }
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 3, 5, 7, 9, 25, 30 };

            Console.WriteLine(BinarySearchRec(first, 7, 8));
            Console.WriteLine(BinarySearchRec(first, 7, 25));

            Console.ReadKey();
        }
    }
}
/*
OUTPUT
False
True
*/
