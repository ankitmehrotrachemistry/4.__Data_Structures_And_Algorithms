using System;

namespace minDiff_Sorting
{
    class Program
    {
        public static int findMinDiff(int[] arr, int size)
        {
            Array.Sort(arr);
            int diff = 99999999;

            for(int i = 0; i < size - 1; i++)
            {
                if( (arr[i+1] - arr[i]) < diff)
                {
                    diff = arr[i + 1] - arr[i];
                }
            }

            return diff;
        }
        static void Main(string[] args)
        {
            int[] second = new int[] { 1, 6, 4, 19, 17, 20 };

            Console.WriteLine("Find Minimum Difference : " + findMinDiff(second, second.Length));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Find Minimum Difference : 1
*/
