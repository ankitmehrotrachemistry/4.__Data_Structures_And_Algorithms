using System;

namespace linearSearchSorted
{
    class Program
    {
        public static bool linearSearchSorted(int[] arr, int size, int value)
        {
            for(int i = 0; i < size; i++)
            {
                if(value == arr[i])
                {
                    return true;
                }
                else if(value < arr[i])
                {
                    return false;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 3, 5, 7, 9, 25, 30 };

            Console.WriteLine(linearSearchSorted(first, first.Length, 8));
            Console.WriteLine(linearSearchSorted(first, first.Length, 9));

            Console.ReadKey();
        }
    }
}
/*
OUTPUT
False
True
*/
