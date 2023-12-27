using System;
using System.Collections.Generic;

namespace Queue_Sliding_Window_First_Negative
{
    class Program
    {
        public static void firstNegativeSlidingWindow(int[] arr, int size, int k)
        {
            Queue<int> queue = new Queue<int>();
            
            Console.Write("First Negative in SlidingWindow : ");
            for (int i = 0; i < size; i++)
            {
                if(queue.Count > 0 && queue.Peek() <= i - k)
                {
                    queue.Dequeue();
                }

                if (arr[i] < 0)
                    queue.Enqueue(i);

                if (i >= (k - 1))
                {
                    if (queue.Count > 0)
                        Console.Write(arr[queue.Peek()] + " ");
                    else
                        Console.Write("NAN");
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, -2, -6, 10, -14, 50, 14, 21 };
            firstNegativeSlidingWindow(arr, 7, 3);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
First Negative in SlidingWindow : -2 -2 -6 -14 -14
*/
