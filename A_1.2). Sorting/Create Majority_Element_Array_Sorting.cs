using System;

namespace Majority_Element_Array_Sorting
{
    class Program
    {
        public static int getMajority2(int[] arr, int size)
        {
            int majIndex = size / 2, count = 1;

            int candidate;
            Array.Sort(arr);

            candidate = arr[majIndex];
            count = 0;

            for(int i = 0; i < size; i++)
            {
                if(arr[i] == candidate)
                {
                    count++;
                }
            }

            if(count > size/2)
            {
                return arr[majIndex];
            }
            else
            {
                return int.MinValue;
            }
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 5, 5, 13, 5, 31, 5 };

            Console.Write("Majority Element in Array using Sorting is : " + getMajority2(first, first.Length));
            
            Console.ReadKey();
        }
    }
}

/*
INPUT
Majority Element in Array using Sorting is : 5
*/
