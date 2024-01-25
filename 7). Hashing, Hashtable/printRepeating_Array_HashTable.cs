using System;
using System.Collections.Generic;

namespace printRepeating_Array_HashTable
{
    class Program
    {
        public static void printRepeating3(int[] arr, int size)
        {
            HashSet<int> hs = new HashSet<int>();

            Console.Write("Repeating Elements are :");

            for(int i = 0; i < size; i++)
            {
                if(hs.Contains(arr[i]))
                {
                    Console.Write(" " + arr[i]);
                }
                else
                {
                    hs.Add(arr[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 3, 5, 3, 9, 1, 30 };

            printRepeating3(first, first.Length);

            Console.ReadKey();
        }
    }
}
/*
OUTPUT
Repeating Elements are : 3 1
*/
