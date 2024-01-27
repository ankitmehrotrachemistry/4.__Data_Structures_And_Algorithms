using System;

// For each element in list find if there is some other element, which sums up to the desired value.

namespace findPair_Sum_Array_BruteForce
{
    class Program
    {
        public static bool FindPair(int[] arr, int size, int value)
        {
            for(int i = 0; i < size; i++)
            {
                for(int j = i + 1; j < size; j++)
                {
                    if((arr[i] + arr[j]) == value)
                    {
                        Console.WriteLine("The Pair is : " + arr[i] + "," + arr[j]);
                        
                        return true;
                    }
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 5, 4, 3, 2, 7, 8, 9, 6 };

            Console.WriteLine(FindPair(first, first.Length, 8));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
The Pair is : 1,7
True
*/
