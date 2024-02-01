using System;

namespace Majority_Element_Array_BruteForce
{
    class Program
    {
        public static int getMajority(int[] arr, int size)
        {
            int max = 0, count = 0, maxCount = 0;

            for(int i = 0; i < size; i++)
            {
                for(int j = i + 1; j < size; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        count++;
                    }
                }

                if(count > maxCount)
                {
                    max = arr[i];
                    maxCount = count;
                }
            }

            Console.Write("The Maximum Element in Array is : ");

            if(maxCount > size/2)
            {
                return max;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 5, 5, 13, 5, 31, 5 };

            Console.WriteLine(getMajority(first, first.Length));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
The Maximum Element in Array is : 5
*/
