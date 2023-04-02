using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexArray_0_N_1
{
    internal class Program
    {
        public static void IndexArray(int[] arr, int size)
        {
            for(int i = 0; i < size; i++)
            {
                int curr = i;
                int value = -1;

                while (arr[curr] != -1 && arr[curr] != curr)
                {
                    int temp = arr[curr];
                    arr[curr] = value;
                    value = curr = temp;
                }

                if(value != -1)
                {
                    arr[curr] = value;
                }
            }
        }
        public static void PrintArray(int[] array, int length)
        {
            Console.WriteLine("Array Elements in Wave form are : ");

            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arrayIndex = new int[] {8, -1, 6, 1, 9, 3, 2, 7, 4, -1};

            int size = arrayIndex.Length;

            IndexArray(arrayIndex, size);

            PrintArray(arrayIndex, size);
        }
    }
}