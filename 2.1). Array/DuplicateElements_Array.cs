using System;

namespace Array_DuplicateElements
{
    internal class Program
    {
        static void PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void FindDuplicates(int[] arr)
        {
            int n = arr.Length;
            bool isDuplicate = false;

            Console.WriteLine("Duplicate Elements are :");
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.Write(arr[j] + ", ");
                        isDuplicate = true;
                    }
                }
            }
            if (!isDuplicate)
            {
                Console.WriteLine("No Duplicate");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 1, 5, 2, 5, 8, 8, 4 };

            Console.WriteLine("Original Array : ");
            PrintArray(arr);

            FindDuplicates(arr);

            Console.ReadKey();
        }
    }
}
/*
OUTPUT 
Original Array :
1 2 3 4 1 5 2 5 8 8 4
Duplicate Elements are :
1, 2, 4, 5, 8,
*/
