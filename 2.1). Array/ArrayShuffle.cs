using System;

namespace ArrayShuffle
{
    class Program
    {
        static void Randomize(int[] arr, int n)
        {
            Random r = new Random();

            for (int i = n - 1; i > 0; i--)
            {
                int j = r.Next(0, i + 1);

                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };

            int n = arr.Length;
            Randomize(arr, n);

            Console.ReadKey();
        }
    }
}
/*
OUTPUT
5 1 6 4 3 7 8 2
*/
