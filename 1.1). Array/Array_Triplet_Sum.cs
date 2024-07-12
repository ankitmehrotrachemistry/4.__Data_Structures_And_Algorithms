using System;

namespace Array_Triplet_Sum
{
    class Program
    {
        static bool findThreeNumbers(int[] A, int arr_size, int sum)
        {
            for (int i = 0; i < arr_size - 2; i++)
            {
                for (int j = i + 1; j < arr_size - 1; j++)
                {
                    for (int k = j + 1; k < arr_size; k++)
                    {
                        if (A[i] + A[j] + A[k] == sum)
                        {
                            Console.WriteLine("Triplet is : " + A[i] + " " + A[j] + " " + A[k]);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 45, 6, 10, 8 };
            int sum = 22;
            int arr_size = arr.Length;

            findThreeNumbers(arr, arr_size, sum);

            Console.ReadKey();
        }
    }
}

/*OUTPUT
Triplet is : 4 10 8*/
