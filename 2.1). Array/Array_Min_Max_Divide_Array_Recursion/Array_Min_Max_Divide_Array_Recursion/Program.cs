using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Min_Max_Divide_Array_Recursion
{
    class Program
    {
        public class Pair
        {
            public int min;
            public int max;
        }
        static Pair getMinMax(int[] arr, int low, int high)
        {
            Pair minmax = new Pair();
            Pair minmaxLeft = new Pair();
            Pair minmaxRight = new Pair();
            int mid;

            if (low == high)
            {
                minmax.max = arr[low];
                minmax.min = arr[low];

                return minmax;
            }

            if (high == low + 1)
            {
                if (arr[low] > arr[high])
                {
                    minmax.max = arr[low];
                    minmax.min = arr[high];
                }
                else
                {
                    minmax.max = arr[high];
                    minmax.min = arr[low];
                }
                return minmax;
            }

            mid = (low + high) / 2;

            minmaxLeft = getMinMax(arr, low, mid);
            minmaxRight = getMinMax(arr, mid + 1, high);

            if (minmaxLeft.min < minmaxRight.min)
            {
                minmax.min = minmaxLeft.min;
            }
            else
            {
                minmax.min = minmaxRight.min;
            }

            if (minmaxLeft.max > minmax.max)
            {
                minmax.max = minmaxLeft.max;
            }
            else
            {
                minmax.max = minmaxRight.max;
            }
            return minmax;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1000, 40, 2, 80, 200, 540, 0, 800 };
            int arr_size = 8;

            Pair minmax = getMinMax(arr, 0, arr_size - 1);

            Console.WriteLine("Minimum Element is {0}", minmax.min);
            Console.WriteLine("Maximum Element is {0}", minmax.max);
        }
    }
}