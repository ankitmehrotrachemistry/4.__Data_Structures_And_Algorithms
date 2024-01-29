using System;

namespace findDifferencePair_Sorting
{
    class Program
    {
        public static bool findDifference2(int[] arr, int size, int value)
        {
            int first = 0;
            int second = 0;
            int diff;

            Array.Sort(arr);

            while(first < size && second < size)
            {
                diff = Math.Abs(arr[first] - arr[second]);

                if(diff == value)
                {
                    Console.WriteLine("The Pair is : " + arr[first] + " & " + arr[second]);
                    return true;
                }
                else if(diff > value)
                {
                    first += 1;
                }
                else
                {
                    second += 1;
                }
            }

            return false;
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 5, 4, 3, 2, 7, 8, 9, 6 };

            Console.WriteLine(findDifference2(first, first.Length, 6));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
The Pair is : 1 & 7
True
*/
