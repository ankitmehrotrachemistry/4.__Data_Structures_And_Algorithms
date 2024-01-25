using System;
using System.Collections.Generic;

namespace oddCount_Array_HashTable
{
    class Program
    {
        public static void OddCount(int[] arr, int size)
        {
            Dictionary<int, int> ctr = new Dictionary<int, int>();

            for(int i = 0; i < size; i++)
            {
                if(ctr.ContainsKey(arr[i]))
                {
                    ctr.Remove(arr[i]);
                }
                else
                {
                    ctr[arr[i]] = 1;
                 }
            }

            Console.Write("The Odd number of times appearing elements in Array using HashTable is : ");

            foreach(int ? key in ctr.Keys)
            {
                Console.Write(key + " ");
            }
            Console.WriteLine();

            Console.WriteLine("The Count of odd number of times appearing elements in Array using HashTable is : " + ctr.Count);
        }
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 1, 5, 4, 7, 7, 8 };

            OddCount(first, first.Length);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT :
The Odd number of times appearing elements in Array using HashTable is : 5 4 8
The Count of odd number of times appearing elements in Array using HashTable is : 3
*/
