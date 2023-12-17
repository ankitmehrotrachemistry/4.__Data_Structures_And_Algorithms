// Zero Sum Triplets in array of integers using Sorting

using System;
using System.Linq;

namespace CSharpTestProgram
{
    internal class Program
    {
        public static void ZeroSumTriplets_Sorting(int[] arr, int size)
        {
            int start, stop;
            Array.Sort(arr);

            for (int i = 0; i < size - 2; i++)
            {
                start = i + 1;
                stop = size - 1;

                while (start < stop)
                {
                    if (arr[i] + arr[start] + arr[stop] == 0)
                    {
                        Console.WriteLine("Triplet is : " + arr[i] + ", " + arr[start] + " and " + arr[stop]);

                        start += 1;
                        stop -= 1;
                    }
                    else if (arr[i] + arr[start] + arr[stop] > 0)
                    {
                        stop -= 1;
                    }
                    else
                    {
                        start += 1;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 8, -3 };
            int size = array.Count();

            ZeroSumTriplets_Sorting(array, size);

            Console.ReadKey();
        }
    }
}

/*OUTPUT
Triplet is : -3, 1 and 2*/
