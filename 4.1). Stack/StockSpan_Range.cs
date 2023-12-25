using System;
using System.Collections.Generic;

namespace StockSpan_Range
{
    class Program
    {
        public static int[] StockSpanRange(int[] arr)
        {
            int[] SR = new int[arr.Length];
            SR[0] = 1;

            for(int i = 1; i < arr.Length; i++)
            {
                SR[i] = 1;

                for(int j = i - 1; j >= 0 && arr[i] >= arr[j]; j--)
                {
                    SR[i]++;
                }
            }
            return SR;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 6, 5, 4, 3, 2, 4, 5, 7, 9 };

            int size = arr.Length;
            int[] value = StockSpanRange(arr);

            Console.Write("Stock Span Range : ");

            foreach(int val in value)
            {
                Console.Write(" " + val);
            }

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Stock Span Range :  1 1 1 1 1 4 6 8 9
*/
