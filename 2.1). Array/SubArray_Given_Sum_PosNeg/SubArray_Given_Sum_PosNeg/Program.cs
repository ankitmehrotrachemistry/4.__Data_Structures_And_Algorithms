using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubArray_Given_Sum_PosNeg
{
    class Program
    {
        public static int SubArraySum(int[] arr, int n, int sum)
        {
            int current_sum;
            int i, j;
            for (i = 0; i < n; i++)
            {
                current_sum = 0;

                for (j = i; j < n; j++)
                {
                    current_sum = current_sum + arr[j];

                    if (current_sum == sum)
                    {
                        Console.WriteLine("Sum found between indexes " + i + " and " + j);
                        Console.Write("Subarray Elements are : ");
                        for (int k = i; k <= j; k++)
                        {
                            Console.Write(arr[k] + " ");
                        }
                        return 1;
                    }
                }
            }
            Console.Write("No SubArray is found");
            return 0;
        }
        static void Main(string[] args)
        {
            int[] arr = { 15, 2, 4, 8, 9, 5, 10, 23 };
            int n = arr.Length;
            int sum = 23;

            SubArraySum(arr, n, sum);
        }
    }
}
