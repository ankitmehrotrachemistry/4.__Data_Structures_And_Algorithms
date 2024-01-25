using System;

namespace oddCount2_Array_XORSum
{
    // Given an array in which all the elements appear even number of times except two,
    // which appear odd number of times.
    class Program
    {
        public static void OddCount2(int[] arr, int size)
        {
            int xorSum = 0;
            int first = 0;
            int second = 0;
            int setBit;

            // When we xor all the elements of array then the even number of appearing elements
            // will cancel themselves.

            for (int i = 0; i < size; i++)
            {
                xorSum = xorSum ^ arr[i];
            }

            // If we can divide the array elements in two groups such that these two values go in
            // different groups and then xor the values in these groups then we can get these values separately.
            
            setBit = xorSum & ~(xorSum - 1);

            // Right most set bit is used to separate these two elements.

            for (int i = 0; i < size; i++)
            {
                if((arr[i] & setBit) != 0)
                {
                    first ^= arr[i];
                }
                else
                {
                    second ^= arr[i];
                }
            }

            Console.WriteLine("Elements occuring odd number of times in Array is : " + first + " " +second);

        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 1, 5, 4, 7, 7, 8, 8, 2, 2 };

            OddCount2(first, first.Length);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Elements occuring odd number of times in Array is : 5 4
*/
