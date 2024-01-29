using System;

namespace closestPairSum_BruteForce
{
    class Program
    {
        public static void ClosestPair(int[] arr, int size, int value)
        {
            int diff = 999999;

            int first = -1, second = -1;
            int curr;

            for(int i = 0; i < size; i++)
            {
                for(int j = i + 1; j < size; j++)
                {
                    curr = Math.Abs(value - (arr[i] + arr[j]));

                    if(curr < diff)
                    {
                        diff = curr;
                        first = arr[i];
                        second = arr[j];
                    }
                }
            }

            Console.WriteLine("Closest Pair Sum is : " + first + ", " + second);
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 10, 20, 3, 4, 50, 80 };

            ClosestPair(first, first.Length, 47);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Closest Pair Sum is : 3, 50
*/
