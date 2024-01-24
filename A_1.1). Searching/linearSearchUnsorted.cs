using System;

namespace linearSearchUnsorted
{
    class Program
    {
        public static bool linearSearchUnsorted(int[] arr, int size, int value)
        {
            for(int i = 0; i < size; i++)
            {
                if(value == arr[i])
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 3, 5, 7, 9, 25, 30 };

            Console.WriteLine(linearSearchUnsorted(first, first.Length, 8));
            Console.WriteLine(linearSearchUnsorted(first, first.Length, 9));

            Console.ReadKey();
        }
    }
}
/*
OUTPUT
False
True
*/
