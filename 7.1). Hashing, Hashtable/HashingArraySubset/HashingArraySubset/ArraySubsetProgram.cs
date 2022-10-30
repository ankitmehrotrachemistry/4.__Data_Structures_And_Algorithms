// C# Program to determine whether the array is subset of another Array using Hashing

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashingArraySubset
{
    class ArraySubsetProgram
    {
        public static bool isSubset(int[] array1, int[] array2, int len1, int len2)
        {
            HashSet<int> hSet = new HashSet<int>();

            for (int i = 0; i < len1; i++)
            {
                if (!hSet.Contains(array1[i]))
                {
                    hSet.Add(array1[i]);
                }
            }

            for (int i = 0; i < len2; i++)
            {
                if (!hSet.Contains(array2[i]))
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int[] array1 = new int[] {5,8,3,2,6,9,1};
            int[] array2 = new int[] {8,9,5,1};
            int[] array3 = new int[] {2,1,7,4};

            int len1 = array1.Length;
            int len2 = array2.Length;
            int len3 = array3.Length;

            if (isSubset(array1, array2, len1, len2))
            {
                Console.WriteLine("\nArray2 is a Subset of Array1\n");
            }
            else
            {
                Console.WriteLine("Array2 is not a subset of Array1\n");
            }

            if (isSubset(array1, array3, len1, len3))
            {
                Console.WriteLine("Array3 is a Subset of Array1\n");
            }
            else
            {
                Console.WriteLine("Array3 is not a subset of Array1\n");
            }
        }
    }
}