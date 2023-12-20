using System;

namespace Array_Rearrange_i_j
{
    class Program
    {
        void RearrangeArray(int[] arr, int n)
        {
            int[] temp = new int[n];

            for (int i = 0; i < n; i++)
                temp[arr[i]] = i;

            for (int i = 0; i < n; i++)
                arr[i] = temp[i];
        }

        void PrintArray(int[] arr, int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            int[] arr = { 1, 3, 0, 2, 4 };
            int n = arr.Length;

            Console.WriteLine("The given Array is : ");
            p.PrintArray(arr, n);

            p.RearrangeArray(arr, n);

            Console.WriteLine("The Array after rearranging is : ");
            p.PrintArray(arr, n);

            Console.ReadKey();
        }
    }
}


/* 
     Input: arr[]  = {1, 3, 0, 2};
     Output: arr[] = {2, 0, 3, 1};

     Explanation for the above output.
       Since arr[0] is 1, arr[1] is changed to 0
       Since arr[1] is 3, arr[3] is changed to 1
       Since arr[2] is 0, arr[0] is changed to 2
       Since arr[3] is 2, arr[2] is changed to 3
*/
