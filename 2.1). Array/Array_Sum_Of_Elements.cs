using System;

namespace Array_Sum_Of_Elements
{
    internal class Program
    {
        public static int SumOfArray(int[] arr)
        {
            int size = arr.Length;
            int totalSum = 0;

            for (int i = 0; i < size; i++)
            {
                totalSum = totalSum + arr[i];
            }
            return totalSum;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 12, 10, 2, 17, 6, 40 };

            Console.WriteLine("Sum of Elements is : " + SumOfArray(array));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Sum of Elements is : 87
*/
