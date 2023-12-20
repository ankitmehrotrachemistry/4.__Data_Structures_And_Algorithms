using System;

namespace SubArray_Given_Sum
{
    class Program
    {
        public static int SubArraySum(int[] arr, int n , int sum)
        {
            int currentSum;

            for(int i = 0; i < n; i++)
            {
                currentSum = 0;

                for(int j = i; j < n; j++)
                {
                    currentSum = currentSum + arr[j];

                    if(currentSum == sum)
                    {
                        Console.WriteLine("Sum found between indexes " + i + " and " + j);

                        Console.Write("Subarray Elements are : ");

                        for(int k = i; k <= j; k++)
                        {
                            Console.Write(arr[k] + " ");
                        }
                        return 1;
                    }
                }
            }
            Console.Write("No SubArray found");
            return 0;
        }
        static void Main(string[] args)
        {
            int[] arr = { 15, 2, 4, 8, 9, 5, 10, 23 };
            int n = arr.Length;
            int sum = 24;

            SubArraySum(arr, n, sum);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Sum found between indexes 4 and 6
Subarray Elements are : 9 5 10
*/
