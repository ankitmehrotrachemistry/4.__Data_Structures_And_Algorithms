// In Array of n numbers , find 2 elements (pair) such that their sum = value using HashSet

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpTestProgram
{
    internal class Program
    {
        public static bool FindPair_HashSet(int[] arr, int size, int value)
        {
            HashSet<int> hs = new HashSet<int>();

            for(int i = 0; i < size; i++)
            {
                if(hs.Contains(value - arr[i]))
                {
                    Console.WriteLine("The pair is : " + arr[i] + " , " + (value - arr[i]));
                    return true;
                }
                hs.Add(arr[i]);
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] array = { 1,2,3,4,8,5,7,9,10 };
            int size = array.Count();
            int value = 10;

            Console.WriteLine("In Array, " + FindPair_HashSet(array, size, value));
            Console.ReadKey();
        }
    }
}
