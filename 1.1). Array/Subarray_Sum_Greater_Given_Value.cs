using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subarray_Sum_Greater_Given_Value
{
    class Program
    {
        static int SmallestSubArrayWithSum(int[] arr, int n, int x)
        {
            int min_Len = n + 1;

            Console.Write("SubArray is : ");
            for (int start = 0; start < n; start++)
            {
                int current_sum = arr[start];

                if (current_sum > x)
                    return 1;
                for (int end = start + 1; end < n; end++)
                {
                    current_sum += arr[end];

                    if (current_sum > x && (end - start + 1) < min_Len)
                        min_Len = (end - start + 1);
                }

                for (int k = start + 1; k <  start + 1; k++)
                {
                    Console.Write(arr[k] + " ");
                }
            }
            return min_Len;
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 4, 45, 6, 10, 19 };
            int x = 51;
            int n1 = arr1.Length;
            int res1 = SmallestSubArrayWithSum(arr1, n1, x);
            if (res1 == n1 + 1)
                Console.WriteLine("Not Possible");
            else
                Console.WriteLine(" and Length of Smallest SubArray is " + res1);
/*
            int[] arr2 = { 1, 10, 5, 2, 7 };
            int n2 = arr2.Length;
            x = 9;
            int res2 = SmallestSubArrayWithSum(arr2, n2, x);
            if (res2 == n2 + 1)
                Console.WriteLine("Not Possible");
            else
                Console.WriteLine(res2);*/
        }
    }
}
