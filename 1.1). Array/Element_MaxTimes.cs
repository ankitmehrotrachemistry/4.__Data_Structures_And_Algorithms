// C# program to find element which appears maximum number of times

using System;

namespace CSharpTestProgram
{
    internal class Program
    {
        public static int GetMaximum(int[] arr, int size)
        {
            int max = arr[0], count, maxCount = 1;

            for (int i = 0; i < size; i++)
            {
                count = 1;

                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    max = arr[i];
                    maxCount = count;
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

/*
OUTPUT
The element appearing maximum number of time is : 1
*/
