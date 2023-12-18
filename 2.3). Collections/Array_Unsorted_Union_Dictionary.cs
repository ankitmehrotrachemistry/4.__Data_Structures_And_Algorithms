using System;
using System.Collections.Generic;

namespace Array_Unsorted_Union_Dictionary
{
    class Program
    {
        static void printUnion(int[] a, int n, int[] b, int m)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                if (!dict.ContainsKey(a[i]))
                    dict.Add(a[i], i);
            }
            for (int i = 0; i < m; i++)
            {
                if (!dict.ContainsKey(b[i]))
                    dict.Add(b[i], i);
            }

            Console.WriteLine("Union of 2 Arrays are : ");
            foreach (KeyValuePair<int, int> dictElem in dict)
            {
                Console.Write(dictElem.Key + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 5, 6, 2, 3, 5 };
            int[] b = { 2, 4, 5, 6, 8, 9, 4, 6, 5 };

            printUnion(a, 7, b, 9);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Union of 2 Arrays are :
1 2 5 6 3 4 8 9
*/
