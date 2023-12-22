using System;

namespace String_Two_Permutation
{
    class Program
    {
        public static bool isPermutation(string s1, string s2)
        {
            int[] count1 = new int[256];
            int[] count2 = new int[256];

            for(int i = 0; i < s1.Length && i < s2.Length; i++)
            {
                count1[s1[i]]++;
                count2[s2[i]]++;
            }

            if (s1.Length != s2.Length)
                return false;

            for (int i = 0; i < 256; i++)
                if (count1[i] != count2[i])
                    return false;

            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(isPermutation("apple", "pepla"));
            Console.WriteLine(isPermutation("apple", "peepa"));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
True
False
*/
