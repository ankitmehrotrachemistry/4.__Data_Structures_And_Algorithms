using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Neg_Begin_Pos_End_Two_Pointer
{
    // We take 2 Variables left and right which hold 0 and N-1 indexes.
    class Program
    {
        static void shiftAll(int[] arr, int left, int right)
        {
            while (left <= right)
            {
                if (arr[left] < 0 && arr[right] < 0)
                    left++;
                else if (arr[left] > 0 && arr[right] < 0)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
                else if (arr[left] > 0 && arr[right] > 0)
                    right--;
                else
                {
                    left++;
                    right--;
                }
            }
        }
        static void displayArray(int[] arr, int right)
        {
            for (int i = 0; i <= right; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = { -12, 11, -13, -5, 6, -7, 5, -3, 11 };
            int arr_size = arr.Length;

            shiftAll(arr, 0, arr_size - 1);
            displayArray(arr, arr_size-1);
        }
    }
}
