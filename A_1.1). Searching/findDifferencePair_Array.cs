using System;

namespace findDifferencePair_Array
{
    class Program
    {
        public static bool findDifference(int[] arr, int size, int value)
        {
            for(int i = 0; i < size; i++)
            {
                for(int j = i + 1; j < size; j++)
                {
                    if(Math.Abs(arr[i] - arr[j]) == value)
                    {
                        Console.WriteLine("The Pair is : " + arr[i] + " & " + arr[j]);
                        return true;
                    }
                }
            }

            return false;
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 5, 4, 3, 2, 7, 8, 9, 6 };

            Console.WriteLine(findDifference(first, first.Length, 6));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
The Pair is : 1 & 7
True
*/
