// Start from the last element, swap it with a randomly selected element from the whole array (including last).
// Now consider the array from 0 to n-2 (size reduced by 1), and repeat the process till we hit the first element. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayShuffle
{
    class Program
    {
        static void Randomize(int[] arr, int n)
        {
            Random r = new Random();

            for (int i = n - 1; i > 0; i--)
            {
                int j = r.Next(0, i+1);

                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
            for(int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5,6,7,8};

            int n = arr.Length;
            Randomize(arr, n);
        }
    }
}
