using System;
using System.Collections.Generic;

namespace Get_MaximumArea_Histogram2
{
    class Program
    {
        public static int GetMaxArea2(int[] arr)
        {
            int size = arr.Length;
            Stack<int> stack = new Stack<int>();
            int maxArea = 0;
            int top;
            int topArea;
            int i = 0;
            
            while(i < size)
            {
                while((i < size) && (stack.Count == 0 || arr[stack.Peek()] <= arr[i]))
                {
                    stack.Push(i);
                    i++;
                }
                while (stack.Count > 0 && (i == size || arr[stack.Peek()] > arr[i]))
                {
                    top = stack.Peek();
                    stack.Pop();
                    topArea = arr[top] * (stack.Count == 0 ? i : i - stack.Peek() - 1);

                    if(maxArea < topArea)
                    {
                        maxArea = topArea;
                    }
                }
            }
            return maxArea;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 7, 6, 5, 4, 4, 1, 6, 3, 1 };

            int size = arr.Length;
            int value = GetMaxArea2(arr);

            Console.Write("Get Max Area : " + value);

            Console.ReadKey();
        }
    }
}
/*
OUTPUT
Get Max Area : 20
*/
