using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Rotation_k_Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 7, 9, 12, 5, 18, 20 };

            Console.Write("Original Array is : ");

            foreach (int i in arr)
                Console.Write(i + " ");

            Console.Write("\n");
            Console.Write("Enter number of rotations you want : ");

            int k = Int32.Parse(Console.ReadLine());

            if (k > arr.Length)
            {
                Console.WriteLine("Invalid Value of k");
            }
            for (int i = 0; i < k; i++)
            {
                int last = arr[arr.Length - 1];
                for (int j = arr.Length - 2; j >= 0; j--)
                {
                    arr[j + 1] = arr[j];
                }
                arr[0] = last;
            }
            Console.WriteLine("Rotated Array is : ");
            foreach (int i in arr)
                Console.Write(i + " ");
            Console.Write("\n");
        }
    }
}
