using System;

namespace findMissingNumber_Array_XOR
{
    class Program
    {
        public static int findMissingNumber2(int[] arr, int size)
        {
            int xorSum = 0;

            for (int i = 1; i < size + 2; i++)
            {
                xorSum ^= i;
            }

            for (int i = 0; i < size; i++)
            {
                xorSum ^= arr[i];
            }

            return xorSum;
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 5, 4, 3, 2, 7, 8, 9 };

            Console.Write("The missing number in Array using XOR is : ");

            int missingNumber = findMissingNumber2(first, first.Length);

            Console.WriteLine(missingNumber);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
The missing number in Array using XOR is : 6
*/
