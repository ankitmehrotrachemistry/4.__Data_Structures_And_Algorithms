using System;

namespace KthMinimumProduct_QuickSelect
{
    class Program
    {
        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static void QuickSelectUtil(int[] arr, int lower, int upper, int k)
        {
            if (upper <= lower)
                return;

            int pivot = arr[lower];
            int start = lower;
            int stop = upper;

            while (lower < upper)
            {
                while (lower < upper && arr[lower] <= pivot)
                {
                    lower++;
                }
                while (lower <= upper && arr[upper] > pivot)
                {
                    upper--;
                }
                if (lower < upper)
                {
                    Swap(arr, upper, lower);
                }
            }

            Swap(arr, upper, start); // upper is the pivot position
            if (k < upper)
                QuickSelectUtil(arr, start, upper - 1, k); // pivot -1 is the upper for left sub array.
            if (k > upper)
                QuickSelectUtil(arr, upper + 1, stop, k); // pivot + 1 is the lower for right sub array.
        }
        public static int KSmallestProduct3(int[] arr, int size, int k)
        {
            QuickSelectUtil(arr, 0, size - 1, k);

            int product = 1;

            for (int i = 0; i < k; i++)
                product *= arr[i];

            return product;
        }
        static void Main(string[] args)
        {
            int[] arr2 = new int[] { 8, 7, 6, 5, 7, 3, 2, 1 };
            Console.WriteLine("Kth Smallest product is : " + KSmallestProduct3(arr2, 8, 4));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Kth Smallest product is : 30
*/
