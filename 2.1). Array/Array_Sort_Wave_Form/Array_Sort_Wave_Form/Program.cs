using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sort_Wave_Form
{
    internal class Program
    {
        public static void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
        public static void WaveArraySort(int[] arr)
        {
            int size = arr.Length;

            Array.Sort(arr);

            for(int i = 0; i < size - 1; i+= 2)
            {
                Swap(arr, i, i + 1);
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
            int[] arrayWave = new int[] { 8, 1, 2, 3, 4, 5, 6, 7};
            WaveArraySort(arrayWave);

            PrintArray(arrayWave, arrayWave.Length);
        }
    }
}
