using System;
using System.Collections.Generic;

// For each element in list find if there is some other element, which sums up to the desired value using HashSet.

namespace findPair_Sum_Array_HashSet
{
    class Program
    {
        public static bool FindPair3(int[] arr, int size, int value)
        {
            HashSet<int> hs = new HashSet<int>();

            for(int i = 0; i < size; i++)
            {
                if(hs.Contains(value - arr[i]))
                {
                    Console.WriteLine("The Pair is : " + arr[i] + " , "  + (value - arr[i]));
                    return true;
                }

                hs.Add(arr[i]);
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 5, 4, 3, 2, 7, 8, 9, 6 };

            Console.WriteLine(FindPair3(first, first.Length, 8));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
The Pair is : 3 , 5
True
*/
