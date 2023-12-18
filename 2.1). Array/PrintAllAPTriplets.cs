// C# program to print all triplets in given array  that form Arithmetic Progression

using System;

namespace CSharpTestProgram
{
    internal class Program
    {
        public static void printAllAPTriplets(int[] arr, int size)
        {
            int i, j, k;

            for (i = 1; i < size - 1; i++)
            {
                j = i - 1;
                k = i + 1;

                while (j >= 0 && k < size)
                {
                    if (arr[j] + arr[k] == 2 * arr[i])
                    {
                        Console.WriteLine("Triplet is : " + arr[j] + ", " + arr[i] + " and " + arr[k]);
                        k += 1;
                        j -= 1;
                    }
                    else if (arr[j] + arr[k] < 2 * arr[i])
                    {
                        k += 1;
                    }
                    else
                    {
                        j -= 1;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 2, 6, 9, 12, 17, 22, 31, 32, 35, 42 };
            int size = array.Length;

            printAllAPTriplets(array, size);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Triplet is : 6, 9 and 12
Triplet is : 2, 12 and 22
Triplet is : 12, 17 and 22
Triplet is : 2, 17 and 32
Triplet is : 12, 22 and 32
Triplet is : 9, 22 and 35
Triplet is : 2, 22 and 42
Triplet is : 22, 32 and 42
*/
