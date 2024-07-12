// Sum of distinct elements of Array where they may be repeated elements
// If there is some value repeated continuously then they should be added once.

using System;

namespace CSharpTestProgram
{
    internal class Program
    {
        public static int SumOfDistinct(int[] arr, int size)
        {
            int sum = 0;

            Array.Sort(arr);

            for(int i = 0; i < size - 1; i++)
            {
                if (arr[i] != arr[i+1])
                {
                    sum += arr[i];
                }
            }
            sum += arr[size - 1];

            return sum;
        }
        static void Main(string[] args)
        {
            int[] array = { 4,1,2,3,4,1,3,5,8,2,10,5};

            // Twice (4,1,2,3,5) Once(8,10) => 4 + 1 + 2 + 3 + 5 + 8 + 10 = 33

            int size = array.Length;

            Console.WriteLine("Sum of distinct elements are : " + SumOfDistinct(array, size));
            Console.ReadKey();
        }
    }
}
