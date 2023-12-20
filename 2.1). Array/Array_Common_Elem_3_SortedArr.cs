using System;

namespace Array_Common_Elem_3_SortedArr
{
    class Program
    {
        static void findCommonElement(int[] arr1, int[] arr2, int[] arr3)
        {
            int i = 0, j = 0, k = 0;

            while(i < arr1.Length && j < arr2.Length && k < arr3.Length)
            {
                if (arr1[i] == arr2[j] && arr2[j] == arr3[k])
                {
                    Console.Write(arr1[i] + " ");
                    i++;
                    j++;
                    k++;
                }
                else if (arr1[i] < arr2[j])
                    i++;
                else if (arr2[j] < arr3[k])
                    j++;
                else
                    k++;
            }
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 5, 10, 20, 40, 80 };
            int[] arr2 = { 6, 7, 20, 80, 100 };
            int[] arr3 = { 3, 4, 15, 20, 30, 70, 80, 120 };

            Console.Write("Common Elements are : ");

            findCommonElement(arr1, arr2, arr3);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Common Elements are : 20 80
*/
