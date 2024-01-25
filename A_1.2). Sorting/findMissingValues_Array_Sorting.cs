using System;

namespace findMissingValues_Array_Sorting
{
    class Program
    {
        public static void MissingValues(int[] arr, int size)
        {
            Array.Sort(arr);

            int value = arr[0];
            int i = 0;

            while(i < size)
            {
                if(value == arr[i])
                {
                    value += 1;
                    i += 1;
                }
                else
                {
                    Console.WriteLine(value);
                    value += 1;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 5, 4, 6, 2, 7, 8, 9 };

            Console.Write("The missing value in Array using Sorting is : " );

            MissingValues(first, first.Length);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
The missing value in Array using Sorting is : 3
*/
