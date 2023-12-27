using System;
using System.Collections.Generic;

namespace Queue_Sliding_Window_Minimum_Of_Maximum
{
    class Program
    {
        public static int minimumOfMaximumSlidingWindow(int[] arr, int size, int k)
        {
            LinkedList<int> queue = new LinkedList<int>();
            int minVal = 999999;

            Console.Write("Maximum value in Sliding Window is : ");
            for (int i = 0; i < size; i++)
            {
                if(queue.Count > 0 && queue.First.Value <= i - k)
                {
                    queue.RemoveFirst();
                }
                while(queue.Count > 0 && arr[queue.Last.Value] <= arr[i])
                {
                    queue.RemoveLast();
                }
                queue.AddLast(i);

                if (i >= (k - 1))
                {
                    Console.Write(arr[queue.First.Value] + " ");
                }

                if (i >= (k - 1) && minVal > arr[queue.First.Value])
                {
                    minVal = arr[queue.First.Value];
                }
            }

            Console.WriteLine("\nMinimum of Maximum value in Sliding Window is : " + minVal);
            return minVal;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 11, 2, 75, 92, 59, 90, 55 };
            minimumOfMaximumSlidingWindow(arr, 7, 3);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Maximum value in Sliding Window is : 75 92 92 92 90
Minimum of Maximum value in Sliding Window is : 75
*/
