using System;
using System.Collections.Generic;

namespace Queue_Sliding_Window_Maximum
{
    class Program
    {
        public static void MaximumSlidingWindow(int[] arr, int size, int k)
        {
            LinkedList<int> queue = new LinkedList<int>();

            Console.Write("Maximum value in Sliding Window is : ");
            for(int i = 0; i < size; i++)
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

                if(i >= (k - 1))
                {
                    Console.Write(arr[queue.First.Value] + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 11, 2, 75, 92, 59, 90, 55 };
            int k = 3;
            MaximumSlidingWindow(arr, 7, 3);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Maximum value in Sliding Window is : 75 92 92 92 90
*/
