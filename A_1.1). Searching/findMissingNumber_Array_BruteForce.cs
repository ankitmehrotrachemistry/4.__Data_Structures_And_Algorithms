using System;

namespace findMissingNumber_Array_BruteForce
{
    class Program
    {
        public static int findMissingNumber(int[] arr, int size)
        {
            int found = 0;

            for(int i = 1; i <= size; i++)
            {
                found = 0;

                for(int j = 0; j < size; j++)
                {
                    if(arr[j] == i)
                    {
                        found = 1;
                        break;
                    }
                }

                if(found == 0)
                {
                    return i;
                }
            }

            return int.MaxValue;
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 5, 4, 3, 2, 7, 8, 9 };

            Console.Write("The missing number in Array is : ");

            Console.WriteLine(findMissingNumber(first, first.Length));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
The missing number in Array is : 6
*/
