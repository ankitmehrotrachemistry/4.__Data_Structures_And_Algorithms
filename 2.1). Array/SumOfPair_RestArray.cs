// Sum of Pair equal to rest Array

using System;
using System.Linq;

namespace CSharpTestProgram
{
    internal class Program
    {
        public static bool SumOfPair_RestArray(int[] arr, int size)
        {
            int total, value;
            int low, high;
            int curr;

            Array.Sort(arr);

            total = 0;

            for (int i = 0; i < size; i++)
            {
                total += arr[i];
            }

            value = total / 2;

            low = 0;
            high = size - 1;

            while (low < high)
            {
                curr = arr[low] + arr[high];

                if (curr == value)
                {
                    Console.WriteLine("Pair is : " + arr[low] + " and  " + arr[high]);
                    return true;
                }
                else if (curr < value)
                {
                    low += 1;
                }
                else
                {
                    high -= 1;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 8 };
            int size = array.Count();

            Console.WriteLine("Output is : " + SumOfPair_RestArray(array, size));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
  Pair is : 1 and 8
  Output is : True
*/
