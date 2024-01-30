using System;

namespace minimumDiffPair_Sorting_Two_Array
{
    class Program
    {
        public static int MinDiffPair(int[] arr1, int size1, int[] arr2, int size2)
        {
            int minDiff = int.MaxValue;

            int first = 0;
            int second = 0;

            int out1 = 0, out2 = 0, diff;

            Array.Sort(arr1);
            Array.Sort(arr2);

            while(first < size1 && second < size2)
            {
                diff = Math.Abs(arr1[first] - arr2[second]);

                if(minDiff > diff)
                {
                    minDiff = diff;
                    out1 = arr1[first];
                    out2 = arr2[second];
                }

                if(arr1[first] < arr2[second])
                {
                    first += 1;
                }
                else
                {
                    second += 1;
                }
            }

            Console.WriteLine("The Pair is : " + out1 + " & " + out2);
            Console.WriteLine("Minimum Difference is : " + minDiff);

            return minDiff;
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 5, 4, 3, 2, 7, 8, 9, 6 };
            int[] second = new int[] { 6, 4, 19, 17, 20 };

            MinDiffPair(first, first.Length, second, second.Length);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
The Pair is : 4 & 4
Minimum Difference is : 0
*/
