// C# program to find number of triangles that can be formed from edges (array)

using System;

namespace CSharpTestProgram
{
    internal class Program
    {
        public static int NumberOfTriangles(int[] arr, int size)
        {
            int count = 0;

            for (int i = 0; i < size - 2; i++)
            {
                for (int j = i + 1; j < size - 1; j++)
                {
                    for (int k = j + 1; k < size; k++)
                    {
                        if (arr[i] + arr[j] > arr[k])
                        {
                            count += 1;
                        }
                    }
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] array = { 2, 6, 9, 12, 17, 22, 31, 32, 35, 42 };
            int size = array.Length;

            Console.WriteLine("The number of triangles possible are :" + NumberOfTriangles(array, size));

            Console.ReadKey();
        }
    }
}
/*
OUTPUT
The number of triangles possible are :41
*/
