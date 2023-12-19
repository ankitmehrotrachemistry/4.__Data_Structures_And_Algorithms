using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximumContiguousEven
{
    class maximumContiguousEvenProgram
    {
        static int countMaxContiguous(int[] arr, int n)
        {
            int current_max = 0, max_so_far = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 != 0)
                    current_max = 0;

                else
                {
                    current_max++; // increase count 
                    max_so_far = Math.Max(current_max,
                                        max_so_far);
                }
            }

            return max_so_far;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 0, 2, 4, 3, 8, 9 };
            int n = arr.Length;

            Console.WriteLine(countMaxContiguous(arr, n));
        }
    }
}