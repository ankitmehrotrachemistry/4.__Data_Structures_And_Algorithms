// C# program to find element which appears maximum number of times using Sorting

using System;

namespace CSharpTestProgram
{
    internal class Program
    {
        public static int GetMaximum(int[] arr, int size)
        {
            int max = arr[0],  maxCount = 1;
            int currCount = 1;

            Array.Sort(arr);

            for(int i = 1; i < size; i++)
            {
                if (arr[i] == arr[i-1])
                {
                    currCount++;
                }
                else
                {
                    currCount = 1;
                }
                if(currCount > maxCount)
                {
                    maxCount = currCount;
                    max = arr[i-1];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] array = { 2, 1, 5, 6, 1, 7, 8, 10, 1, 4, 5, 1 };
            int size = array.Length;

            Console.WriteLine("The element appearing maximum number of time is : " + GetMaximum(array, size));

            Console.ReadKey();
        }
    }
}