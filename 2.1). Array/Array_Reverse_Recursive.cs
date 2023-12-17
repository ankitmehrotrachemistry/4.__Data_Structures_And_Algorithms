using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Reverse_Recursive
{
    class Program
    {
        static void ReverseArrayRecursive(int[] arr, int start, int end)
        {
            int temp;
            if (start >= end)
                return;

            temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            ReverseArrayRecursive(arr, start + 1, end - 1);
        }
        static void PrintArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Original Array is : ");
            PrintArray(arr, 10);
            ReverseArrayRecursive(arr, 0, 9);

            Console.WriteLine("Reversed Array is : ");
            PrintArray(arr, 10);

            Console.ReadKey();
        }
    }
}

/*
Original Array is :
1 2 3 4 5 6 7 8 9 10
Reversed Array is :
10 9 8 7 6 5 4 3 2 1
*/
