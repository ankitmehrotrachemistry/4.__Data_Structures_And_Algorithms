using System;

namespace printRepeating_Array_Counting
{
    class Program
    {
        public static void printRepeating4(int[] arr, int size, int range)
        {
            int[] count = new int[range];
            
            for(int i = 0; i < size; i++)
            {
                count[i] = 0;
            }

            Console.Write("Repeating Elements are : ");

            for(int i = 0; i < size; i++)
            {
                if(count[arr[i]] == 1)
                {
                    Console.Write(" " + arr[i]);
                }
                else
                {
                    count[arr[i]]++;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 3, 5, 3, 9, 1, 30 };

            printRepeating4(first, first.Length, 50);

            Console.ReadKey();
        }
    }
}
/*
OUTPUT
Repeating Elements are :  3 1
*/
