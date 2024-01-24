using System;

namespace binarySearchIterative
{
    class Program
    {
        public static bool BinarySearch(int[] arr, int size, int value)
        {
            int low = 0;
            int high = size - 1;
            int mid;

            while(low <= high)
            {
                mid = (low + high) / 2;

                if(arr[mid] == value)
                {
                    return true;
                }
                else if(arr[mid] < value)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 3, 5, 7, 9, 25, 30 };

            Console.WriteLine(BinarySearch(first, 7, 8));
            Console.WriteLine(BinarySearch(first, 7, 25));

            Console.ReadKey();
        }
    }
}
/*
OUTPUT
False
True
*/
