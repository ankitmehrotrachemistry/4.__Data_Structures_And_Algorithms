using System;

namespace closestPairSum_Sorting
{
    class Program
    {
        public static void ClosestPair2(int[] arr, int size, int value)
        {
            int first = 0, second = 0;

            int start = 0;
            int stop = size - 1;

            int diff, curr;

            Array.Sort(arr);

            diff = 99999999;
            {
                while(start < stop)
                {
                    curr = (value - (arr[start] + arr[stop]));

                    if(Math.Abs(curr) < diff)
                    {
                        diff = Math.Abs(curr);
                        first = arr[start];
                        second = arr[stop];
                    }

                    if(curr == 0)
                    {
                        break;
                    }
                    else if(curr > 0)
                    {
                        start += 1;
                    }
                    else
                    {
                        stop -= 1;
                    }
                }
            }

            Console.WriteLine("Closest Pair Sum is : " + first + ", " + second);
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 10, 20, 3, 4, 50, 80 };

            ClosestPair2(first, first.Length, 47);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Closest Pair Sum is : 3, 50
*/
