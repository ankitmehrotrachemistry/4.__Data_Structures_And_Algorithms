using System;

namespace firstRepeatedElement_Array_BruteForce
{
    class Program
    {
        public static int FirstRepeated(int[] arr, int size)
        {
            for(int i = 0; i < size; i++)
            {
                for(int j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                        return arr[i];
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int[] first = new int[] {34, 56, 77, 1, 5, 6, 6, 6, 6, 6, 6, 7, 8, 10, 34, 20};

            Console.WriteLine("First Repeated Element in Array is : " +FirstRepeated(first, first.Length));

            Console.ReadKey();
        }
    }
}
/*
OUTPUT
First Repeated Element in Array is : 34
*/
