using System;
using System.Collections.Generic;

namespace Get_MaximumArea_Histogram
{
    class Program
    {
        public static int GetMaxArea(int[] arr)
        {
            int size = arr.Length;
            int maxArea = -1;
            int currArea;
            int minHeight = 0;

            for(int i = 1; i < size; i++)
            {
                minHeight = arr[i];

                for(int j = i - 1; j >= 0; j--)
                {
                    if(minHeight > arr[j])
                    {
                        minHeight = arr[j];
                    }
                    currArea = minHeight * (i - j + 1);

                    if(maxArea < currArea)
                    {
                        maxArea = currArea;
                    }
                }
            }
            return maxArea;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 7, 6, 5, 4, 4, 1, 6, 3, 1 };

            int size = arr.Length;
            int value = GetMaxArea(arr);

            Console.Write("Get Max Area : " + value);

            Console.ReadKey();
        }
    }
}
/*
OUTPUT
Get Max Area : 20
*/
