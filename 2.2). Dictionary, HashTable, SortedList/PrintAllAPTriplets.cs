// C# program to print all triplets in given array  that form Arithmetic Progression using List (GFG)

using System;
using System.Collections.Generic;

namespace CSharpTestProgram
{
    internal class Program
    {
        public static void printAllAPTriplets(int[] arr, int size)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    int diff = arr[j] - arr[i];

                    bool exists = list.Exists(x => x == (arr[i] - diff));

                    if (exists)
                        Console.WriteLine(arr[i] - diff + " " + arr[i] + " " + arr[j]);
                }
                list.Add(arr[i]);
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
6 9 12
2 12 22
12 17 22
2 17 32
12 22 32
9 22 35
2 22 42
22 32 42
*/
