using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpTestProgram
{
    internal class Program
    {
        public static int OddCount(int[] arr, int size)
        {
            Dictionary<int, int> ctr = new Dictionary<int, int>();
            int count = 0;

            for(int i = 0; i < size; i++)
            {
                if (ctr.ContainsKey(arr[i]))
                {
                    ctr[arr[i]] = ctr[arr[i]] + 1;
                }
                else
                {
                    ctr[arr[i]] = 1;
                }
            }
            for(int i = 0; i < size; i++)
            {
                if (ctr.ContainsKey(arr[i]) && (ctr[arr[i]] % 2 == 1))
                {
                    Console.WriteLine(arr[i]);
                    count++;
                    ctr.Remove(arr[i]);
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] array = { 2,2,5,5,7,8,8,6,6,8,10};
            int size = array.Count();

            Console.WriteLine("Odd Elements in array is " + OddCount(array, size));
            Console.ReadKey();
        }
    }
}
