using System;

namespace printRepeating_Array_Sorting
{
    class Program
    {
        public static void printRepeating2(int[] arr, int size)
        {
            Array.Sort(arr);

            Console.Write("Repeating Elements in Array are : ");

            for(int i = 1; i < size; i++)
            {
                if(arr[i] == arr[i-1])
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 3, 5, 3, 9, 1, 30 };

            printRepeating2(first, first.Length);

            Console.ReadKey();
        }
    }
}
/*
OUTPUT
Repeating Elements in Array are : 1 3
*/
