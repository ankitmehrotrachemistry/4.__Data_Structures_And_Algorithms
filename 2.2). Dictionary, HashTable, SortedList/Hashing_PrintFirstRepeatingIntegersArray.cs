using System;
using System.Collections.Generic;

namespace Hashing_PrintFirstRepeatingIntegersArray
{
    class Program
    {
        public static void printFirstRepeating(int[] arr)
        {
            int size = arr.Length;

            HashSet<int> hs = new HashSet<int>();
            int firstRepeating = int.MaxValue;

            for(int i = size - 1; i >= 0; i--)
            {
                if(hs.Contains(arr[i]))
                {
                    firstRepeating = arr[i];
                }
                hs.Add(arr[i]);
            }
            Console.WriteLine("First Repeating Number is : " + firstRepeating);
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 4, 5, 6, 7, 8, 9, 1 };
            printFirstRepeating(arr1);

            Console.ReadKey();
        }
    }
}
/*
OUTPUT
First Repeating Number is : 1
*/
