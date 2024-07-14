using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortPartitionPositiveNegative
{
    class Program
    {
        static void Rearrange(int[] arr, int n)
        {
            int j = 0, temp;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    j++;
                }
            }
        }
        static void PrintArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = {-2, -5, 0, 1, -15, 2, 5, 8, 7, -4};

            int n = arr.Length;

            Rearrange(arr, n);

            PrintArray(arr, n);
        }
    }
}
