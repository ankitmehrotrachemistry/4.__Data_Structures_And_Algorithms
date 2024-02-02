using System;

namespace MergeSort
{
    class Program
    {
        private static void Merge(int[] arr, int[] tempArray, int lowerIndex, int middleIndex, int upperIndex)
        {
            int lowerStart = lowerIndex;
            int lowerStop = middleIndex;
            int upperStart = middleIndex + 1;
            int upperStop = upperIndex;
            int count = lowerIndex;

            while (lowerStart <= lowerStop && upperStart <= upperStop)
            {
                if (arr[lowerStart] < arr[upperStart])
                {
                    tempArray[count++] = arr[lowerStart++];
                }
                else
                {
                    tempArray[count++] = arr[upperStart++];
                }
            }
            while (lowerStart <= lowerStop)
            {
                tempArray[count++] = arr[lowerStart++];
            }
            while (upperStart <= upperStop)
            {
                tempArray[count++] = arr[upperStart++];
            }
            for (int i = lowerIndex; i <= upperIndex; i++)
            {
                arr[i] = tempArray[i];
            }
        }

        private static void mergeSrt(int[] arr, int[] tempArray, int lowerIndex, int upperindex)
        {
            if (lowerIndex >= upperindex) return;
            int middleindex = (lowerIndex + upperindex) / 2;

            mergeSrt(arr, tempArray, lowerIndex,
            middleindex);

            mergeSrt(arr, tempArray, middleindex + 1,
            upperindex);

            Merge(arr, tempArray, lowerIndex, middleindex, upperindex);
        }
        public static void sort(int[] arr)
        {
            int size = arr.Length;
            int[] tempArray = new int[size];

            mergeSrt(arr, tempArray, 0, size - 1);
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 1, 8, 2, 7, 3, 6, 4, 5 };

            sort(array);

            Console.Write("The Array after Sorting using Merge Sort is : ");

            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

            Console.ReadKey();
        }
    }
}

/*
INPUT
The Array after Sorting using Merge Sort is : 1 2 3 4 5 6 7 8 9
*/
