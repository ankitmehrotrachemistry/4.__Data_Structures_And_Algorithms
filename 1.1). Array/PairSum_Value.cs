// In Array of n numbers , find 2 elements (pair) such that their sum = value

using System;
using System.Linq;

namespace CSharpTestProgram
{
    internal class Program
    {
        public static bool FindPair(int[] arr, int size, int value)
        {
            for(int i = 0; i < size; i++)
            {
                for(int j = i + 1; j < size; j++)
                {
                    if ((arr[i] + arr[j]) == value)
                    {
                        Console.WriteLine("The pair is : " + arr[i] + "," + arr[j]);
                        return true;
                    }
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] array = { 1,2,3,4,8,5,7,9,10 };
            int size = array.Count();
            int value = 10;

            Console.WriteLine("In Array, " + FindPair(array, size, value));
            Console.ReadKey();
        }
    }
}
