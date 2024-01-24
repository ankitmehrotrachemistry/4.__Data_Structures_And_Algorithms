using System;
using System.Collections.Generic;

namespace Hashing_FindMissingNumberInArray
{
    class Program
    {
        public static int findMissing(int[] arr, int start, int end)
        {
            HashSet<int> hs = new HashSet<int>();

            foreach(int i in arr)
            {
                hs.Add(i);
            }

            for(int curr = start; curr <= end; curr++)
            {
                if(hs.Contains(curr) == false)
                {
                    return curr;
                }
            }

            return int.MaxValue;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Missing Number in Array is : " + findMissing(arr, 1, 10));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Missing Number in Array is : 4
*/
