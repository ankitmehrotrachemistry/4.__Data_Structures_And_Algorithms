using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Array_Wave_Form
{
    internal class Program
    {
        public static void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
        public static void PrintArray(int[] array, int length)
        {
            Console.WriteLine("Array Elements in Wave form are : ");

            for(int i = 0; i < length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        public static void WaveArray(int[] arr)
        {
            int size = arr.Length;

            for(int i = 0; i < size; i+= 2)
            {
                if((i-1) >= 0 && arr[i] > arr[i-1])
                {
                    Swap(arr, i, i - 1);
                }
                if((i+1) < size && arr[i] > arr[i+1])
                {
                    Swap(arr, i, i + 1);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arrayWave = new int[] { 8, 1, 2, 3, 4, 5, 6, 4, 2 };

            WaveArray(arrayWave);

            PrintArray(arrayWave, arrayWave.Length);
        }
    }
}
