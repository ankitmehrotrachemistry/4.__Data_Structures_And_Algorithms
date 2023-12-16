// C# program to find majority element in an Array

using System;

namespace CSharpTestProgram
{
    internal class Program
    {
        public static int GetMajority(int[] arr, int size)
        {
            int max = 0, count = 0, maxCount = 0;

            for(int i = 0; i < size; i++)
            {
                for(int j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if(count > maxCount)
                {
                    max = arr[i];
                    maxCount = count;
                }
            }
            if(maxCount > size/2)
            {
                return max;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 2,5,2,6,7,2,2,2,8,1,2,2,2,8,2,2 };
            int size = array.Length;

            Console.WriteLine("The element appearing maximum number of time is : " + GetMajority(array, size));

            Console.ReadKey();
        }
    }
}
