using System;

namespace SumOfPair_RestArray_Sorting
{
    class Program
    {
        public static bool SumPairRestArray(int[] arr, int size)
        {
            int total, low, high, curr, value;

            Array.Sort(arr);
            total = 0;

            for(int i = 0; i < size; i++)
            {
                total += arr[i];
            }

            value = total / 2;

            low = 0;
            high = size - 1;

            while(low < high)
            {
                curr = arr[low] + arr[high];

                if(curr == value)
                {
                    Console.WriteLine("Pair is : " + arr[low] + arr[high]);
                    return true;
                }
                else if(curr < value)
                {
                    low += 1;
                }
                else
                {
                    high -= 1;
                }
            }

            return false;
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 2, 4, 8, 16, 15 };

            Console.WriteLine(SumPairRestArray(first, first.Length));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Pair is : 815
True
*/
