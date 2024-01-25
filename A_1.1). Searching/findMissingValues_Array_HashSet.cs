using System;
using System.Collections.Generic;

namespace findMissingValues_Array_HashSet
{
    class Program
    {
        public static void MissingValues2(int[] arr, int size)
        {
            HashSet<int> ht = new HashSet<int>();

            int minVal = 999999;
            int maxVal = -999999;

            for(int i = 0; i < size; i++)
            {
                ht.Add(arr[i]);

                if(minVal > arr[i])
                {
                    minVal = arr[i];
                }

                if(maxVal < arr[i])
                {
                    maxVal = arr[i];
                }
            }

            for(int i = minVal; i < maxVal + 1; i++)
            {
                if(ht.Contains(i) == false)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 5, 4, 6, 2, 7, 8, 9 };

            Console.Write("The missing value in Array using HashSet is : " );

            MissingValues2(first, first.Length);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
The missing value in Array using HashSet is : 3
*/
