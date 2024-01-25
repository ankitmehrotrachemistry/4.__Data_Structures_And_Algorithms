using System;

namespace removeDuplicates_Array_Sorting
{
    class Program
    {
        public static int[] removeDuplicates(int[] array, int size)
        {
            int j = 0;

            Array.Sort(array);

            for(int i = 1; i < size; i++)
            {
                if(array[i] != array[j])
                {
                    j++;
                    array[j] = array[i];
                }
            }
            int[] ret = new int[j+1];

            Array.Copy(array, ret, j+1);

            return ret;
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 3, 5, 3, 9, 1, 30 };
            int[] ret = removeDuplicates(first, first.Length);

            Console.Write("Array after removing the duplicates are : ");

            for(int i = 0; i < ret.Length; i++)
            {
                Console.Write(ret[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
/*
OUTPUT
Array after removing the duplicates are : 1 3 5 9 30
*/
