using System;
using System.Collections.Generic;

// Two words are anagram if they are of same size and their characters are same.

namespace Hashing_Anagram
{
    class Program
    {
        public static bool IsAnagram(char[] str1, char[] str2)
        {
            int size1 = str1.Length;
            int size2 = str2.Length;

            if (size1 != size2)
                return false;

            Dictionary<char, int> hm = new Dictionary<char, int>();

            foreach(char ch in str1)
            {
                if (hm.ContainsKey(ch))
                    hm[ch] = hm[ch] + 1;
                else
                    hm[ch] = 1;
            }

            foreach(char ch in str2)
            {
                if (hm.ContainsKey(ch) == false || hm[ch] == 0)
                    return false;
                else
                    hm[ch] = hm[ch];
            }
            return true;
        }
        static void Main(string[] args)
        {
            char[] first = "hello".ToCharArray();
            char[] second = "elloh".ToCharArray();
            char[] third = "world".ToCharArray();

            Console.WriteLine("IsAnagram : " + IsAnagram(first, second));
            Console.WriteLine("IsAnagram : " + IsAnagram(second, third));

            Console.ReadKey();
        }
    }
}
/*
OUTPUT
IsAnagram : True
IsAnagram : False
*/
