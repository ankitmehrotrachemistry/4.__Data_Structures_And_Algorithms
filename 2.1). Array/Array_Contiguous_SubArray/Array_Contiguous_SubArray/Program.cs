using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Contiguous_SubArray
{
    internal class Program
    {
        public static int maximumSubArraySum(int[] array, int size)
        {
            int maxSoFar = 0, maxEndHere = 0;

            for(int i = 0; i < size; i++)
            {
                maxEndHere = maxEndHere + array[i];
                if(maxEndHere < 0)
                {
                    maxEndHere = 0;
                }
                if(maxSoFar < maxEndHere)
                {
                    maxSoFar = maxEndHere;
                }
            }
            return maxSoFar;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, -2, 5, 3, 4, -4, 6, -5, 2, 1, 0};

            Console.WriteLine("Maximum Sub Array Sum is : " + maximumSubArraySum(array, 11));
        }
    }
}
