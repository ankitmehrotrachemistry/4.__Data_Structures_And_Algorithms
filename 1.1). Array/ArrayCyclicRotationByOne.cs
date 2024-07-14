using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCyclicRotationByOne
{
    class Program
    {
        static int[] arr = new int[] {1,2,3,4,5};

        static void rotate()
        {
            int x = arr[arr.Length - 1], i;

            for (i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i-1];
            }
                arr[0] = x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Given array is ");
            string array_initial = string.Join(" ", arr);
            Console.WriteLine(array_initial);

            rotate();

            Console.WriteLine("Rotated Array is ");
            string array_rotated = string.Join(" ", arr);
            Console.WriteLine(array_rotated);
        }
    }
}
