using System;

// For each element in list find if there is some other element, which sums up to the desired value.

namespace findPair_Sum_Array_Sorting
{
    class Program
    {
        public static bool FindPair2(int[] arr, int size, int value)
        {
            int first = 0, second = size - 1;
            int curr;

            Array.Sort(arr);

            while(first < second)
            {
                curr = arr[first] + arr[second];

                if(curr == value)
                {
                    Console.WriteLine("The Pair is " + arr[first] + "," + arr[second]);
                    return true;
                }
                else if (curr < value)
                {
                    first++;
                }
                else
                {
                    second--;
                }
            }

            return false;
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 5, 4, 3, 2, 7, 8, 9, 6 };

            Console.WriteLine(FindPair2(first, first.Length, 8));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
The Pair is 1,7
True
*/
