using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Reversal
{
    internal class Program
    {
        static void PrintArray(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void ReverseArray(int[] arr)
        {
            int n = arr.Length;
            for(int i = 0; i < n/2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[n - i - 1];
                arr[n - i - 1] = temp;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5};

            Console.WriteLine("Original Array");
            PrintArray(arr);

            ReverseArray(arr);

            Console.WriteLine("Reversed Array");
            PrintArray(arr);
        }
    }
}
