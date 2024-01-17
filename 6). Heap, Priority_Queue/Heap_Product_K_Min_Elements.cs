using System;

// Given an array of positive elements. Find product of k minimum elements in array.

namespace Heap_Product_K_Min_Elements
{
    class Program
    {
        public static int KSmallestProduct(int[] arr, int size, int k)
        {
            Array.Sort(arr);

            int product = 1;
            for (int i = 0; i < k; i++)
                product *= arr[i];

            return product;
        }
        static void Main(string[] args)
        {
            int[] arr4 = new int[] { 8, 7, 6, 10, 7, 5, 2, 1 };
            Console.WriteLine("Kth Smallest Product is : " + KSmallestProduct(arr4, arr4.Length, 3));
            Console.WriteLine("Kth Smallest Product is : " + KSmallestProduct(arr4, arr4.Length, 4));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Kth Smallest Product is : 10
Kth Smallest Product is : 60
*/
