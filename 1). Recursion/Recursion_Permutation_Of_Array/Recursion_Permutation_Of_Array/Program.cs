using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_Permutation_Of_Array
{
    class createPermutation
    {
        public void SwapTwoNumbers(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public void printPermutation(int[] arr, int k, int m)
        {
            if (k == m)
            {
                for (int i = 0; i <= m; i++)
                    Console.Write("{0}", arr[i]);
                    Console.Write(" ");
            }
            else
                for (int i = k; i <= m; i++)
                {
                    SwapTwoNumbers(ref arr[k], ref arr[i]);
                    printPermutation(arr, k + 1, m);
                    SwapTwoNumbers(ref arr[k], ref arr[i]);
                }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            createPermutation createPerm = new createPermutation();
            int[] arr1 = new int[5];

            Console.WriteLine("Create permutation of Array");

            Console.Write("Input number of elements to store in Array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} number of elements in Array : \n", n);

            for (int i = 0; i < n; i++)
            {
                Console.Write("Element-{0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Permuation with combination of {0} digits are : \n", n);
            createPerm.printPermutation(arr1,0, n-1);
            Console.Write("\n\n");
        }
    }
}
