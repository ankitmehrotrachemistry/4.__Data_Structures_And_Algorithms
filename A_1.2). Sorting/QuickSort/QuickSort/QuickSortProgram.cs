// C# Program to implement Quick Sort

// It is Divide and Conquer Algorithm. It picks the Element as Pivot and partition array around given Pivot.
// Key Process is Partition()

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class QuickSortProgram
    {
        static public int Partition(int[] arr, int left, int right)
        {
            int pivot;
            pivot = arr[left]; // Pivot started from Leftmost Element 
            
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        static public void quickSort(int[] arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    quickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quickSort(arr, pivot + 1, right);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 6, 1, 5, 7, 8, 54, 0, 4, 2, 9 };
            int n = 10, i;
            Console.WriteLine("Implementation of Quick Sort");

            Console.Write("The Array before Quick Sort implementation is :- ");

            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            quickSort(arr, 0, 9);

            Console.Write("\nThe Array after Quick Sort implementation is :- ");

            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}