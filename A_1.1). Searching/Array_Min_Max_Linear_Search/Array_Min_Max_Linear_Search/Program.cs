using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Min_Max_Linear_Search
{
    class Program
    {
        // How do we return multiple values from a C# function? We can do it either using structures or class. 
        class Pair
        {
            public int min;
            public int max;
        }
        static Pair getMinMax(int[] arr, int n)
        {
            Pair minmax = new Pair();
            int i;

            if (n == 1)
            {
                minmax.max = arr[0];
                minmax.min = arr[1];
                return minmax;
            }

            if (arr[0] > arr[1])
            {
                minmax.max = arr[0];
                minmax.min = arr[1];
            }
            else
            {
                minmax.min = arr[0];
                minmax.max = arr[1];
            }

            for (i = 2; i < n; i++)
            {
                if (arr[i] > minmax.max)
                {
                    minmax.max = arr[i];
                }
                else if (arr[i] < minmax.min)
                {
                    minmax.min = arr[i];
                }
            }
            return minmax;
        }
        static void Main(string[] args)
        {
            int[] arr = {100,2,8,0,400,600,250,16};
            int array_size = 8;

            Pair minmax = getMinMax(arr, array_size);
            Console.WriteLine("Minimum Element is : {0}", minmax.min);

            Console.WriteLine("Maximum Element is : {0}", minmax.max);
        }
    }
}
