// C# Program to find most frequent Element in Array using Hashing (HashTable)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashingMostFrequentEle
{
    class MostFrequentElementProgram
    {
        static int mostFrequentElement(int[] array, int n)
        {
            Dictionary<int, int> H = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int key = array[i];

                if (H.ContainsKey(key))
                {
                    int count = H[key];
                    count++;
                    H[key] = count;
                }
                else
                    H.Add(key, 1);
            }

            int min = 0;
            int res = -1;

            foreach (KeyValuePair<int, int> pair in H)
            {
                if (min < pair.Value)
                {
                    res = pair.Key;
                    min = pair.Value;
                }
            }
            return res;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] {1,2,1,4,1,2,1,8};

            int n = arr.Length;

            Console.WriteLine(mostFrequentElement(arr,n));
        }
    }
}
