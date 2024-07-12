// Zero Sum Triplets in array of integers using Brute Force Algorithm

using System;
using System.Linq;

namespace CSharpTestProgram
{
    internal class Program
    {
        public static void ZeroSumTriplets(int[] arr, int size)
        {
            for(int i = 0; i < size - 2; i++)
            {
                for(int j = i + 1; j < size - 1; j++)
                {
                    for(int k = j + 1; k < size; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            Console.WriteLine("Triplet is : " + arr[i] + ", " + arr[j] + " and "+ arr[k]);
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 1,2,3,4,8,-3 };
            int size = array.Count();

            ZeroSumTriplets(array, size);

            Console.ReadKey();
        }
    }
}

/* OUTPUT
Triplet is : 1, 2 and - 3 */
