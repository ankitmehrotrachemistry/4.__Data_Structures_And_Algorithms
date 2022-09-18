// C# Program to implement Bubble Sort Program

// In Bubble Sort, Adjacent Elements are compared and if they are not in order, they are sawpped!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class BubbleSortProgram
    {
        static void Main(string[] args)
        {
            int[] array = {24, 2, 62, 0, 88, 74, 90, 86};
            int temp;

            Console.WriteLine("Unsorted Array is :- ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            for (int i = 0; i <= array.Length - 2; i++)
            {
                for (int j = 0; j <= array.Length - 2; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j+1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            Console.WriteLine("\nSorted Array is:- ");

            foreach (int arr in array)
                Console.Write(arr + " ");
        }
    }
}
