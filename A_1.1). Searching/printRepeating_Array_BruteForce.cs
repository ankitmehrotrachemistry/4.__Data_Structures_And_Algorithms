using System;

namespace printRepeating_Array_BruteForce
{
    class Program
    {
        public static void printRepeating(int[] arr, int size)
        {
            Console.Write("\n Repeating Elements are : ");

            for(int i = 0; i < size; i++)
            {
                for(int j = i + 1; j < size; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        Console.Write(" " + arr[i]);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 3, 5, 3, 9, 1, 30 };

            printRepeating(first, first.Length);

            Console.ReadKey();
        }
    }
}
/*
OUTPUT
Repeating Elements are :  1 3
*/
