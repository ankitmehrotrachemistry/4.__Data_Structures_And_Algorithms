using System;
using System.Collections.Generic;

namespace Hashing_PrintRepeatingIntegersArray
{
    class Program
    {
        public static void printRepeating(int[] arr)
        {
            HashSet<int> hs = new HashSet<int>();

            Console.Write("Repeating Elements are : ");
            foreach(int val in arr)
            {
                if(hs.Contains(val))
                {
                    Console.Write(" " + val);
                }
                else
                {
                    hs.Add(val);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 4, 5, 6, 7, 8, 9, 1 };
            printRepeating(arr1);

            Console.ReadKey();
        }
    }
}
/*
OUTPUT
Repeating Elements are :  4 1
*/
