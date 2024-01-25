using System;
using System.Collections.Generic;

namespace findMissingNumber_Array_HashSet
{
    class Program
    {
        public static int findMissingNumber3(int[] arr, int size)
        {
            HashSet<int> st = new HashSet<int>();

            int i = 0;

            while(i < size)
            {
                st.Add(arr[i]);
                i += 1;
            }

            i = 1;

            while(i <= size)
            {
                if (st.Contains(i) == false)
                    return i;

                i += 1;
            }

            Console.WriteLine("No Number Missing");

            return -1;
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 5, 4, 3, 2, 7, 8, 9 };

            Console.Write("The missing number in Array using XOR is : ");

            int missingNumber = findMissingNumber3(first, first.Length);

            Console.WriteLine(missingNumber);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
The missing number in Array using XOR is : 6
*/
