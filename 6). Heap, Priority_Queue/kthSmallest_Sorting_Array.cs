using System;

namespace kthSmallest_Sorting_Array
{
    class Program
    {
        public static int KthSmallest(int[] arr, int size, int k)
        {
            Array.Sort(arr);
            return arr[k-1];
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 8, 7, 6, 5, 7, 5, 2, 1 };

            Console.WriteLine("Kth smallest element using Array Sorting is : " +KthSmallest(arr, arr.Length, 4));
            
            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Kth smallest element using Array Sorting is : 5
*/
