using System;
using System.Collections.Generic;

namespace StockSpan_Range2
{
    class Program
    {
        public static int[] StockSpanRange2(int[] arr)
        {
            Stack<int> stack = new Stack<int>();

            int[] SR = new int[arr.Length];
            stack.Push(0);
            SR[0] = 1;

            for(int i = 1; i < arr.Length; i++)
            {
                while(stack.Count > 0 && arr[stack.Peek()] <= arr[i])
                {
                    stack.Pop();
                }
                SR[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());
                stack.Push(i);
            }
            return SR;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 6, 5, 4, 3, 2, 4, 5, 7, 9 };

            int size = arr.Length;
            int[] value = StockSpanRange2(arr);

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
