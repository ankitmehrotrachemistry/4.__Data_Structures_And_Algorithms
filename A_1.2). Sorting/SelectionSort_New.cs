using System;

namespace SelectionSort_New
{
    class Program
    {
        public static void Sort(int[] arr)
        {
            int size = arr.Length;
            int i, j, min, temp;

            for(i = 0; i < size - 1; i++)
            {
                min = i;

                for(j = i + 1; j < size; j++)
                {
                    if(arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 1, 8, 2, 7, 3, 6, 4, 5};

            Console.Write("The Array after Sorting using Selection Sort is : ");

            Sort(array);

            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
The Array after Sorting using Selection Sort is : 1 2 3 4 5 6 7 8 9
*/
