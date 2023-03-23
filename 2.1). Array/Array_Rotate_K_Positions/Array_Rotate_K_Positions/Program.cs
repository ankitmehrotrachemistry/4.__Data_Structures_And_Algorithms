using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Rotate_K_Positions
{
    internal class Program
    {
        public static void rotateArray(int[] array, int n, int k)
        {
            ReverseArray(array, 0, k-1);
            ReverseArray(array, k, n - 1);
            ReverseArray(array, 0, n - 1);
        }

        public static void ReverseArray(int[] array, int start, int end)
        {
            for(int i = start, j = end; i < j; i++, j--)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        public static void PrintArray(int[] array, int length)
        {
            Console.WriteLine("Array Elements after K rotations are : ");

            for(int i = 0; i < length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            rotateArray(array, array.Length, 2);

            PrintArray(array, array.Length);
        }
    }
}