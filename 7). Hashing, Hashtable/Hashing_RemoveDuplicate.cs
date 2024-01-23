using System;
using System.Collections.Generic;

namespace Hashing_RemoveDuplicate
{
    class Program
    {
        public static string RemoveDuplicate(char[] str)
        {
            HashSet<char> hs = new HashSet<char>();
            string outValue = "";

            foreach(char ch in str)
            {
                if(hs.Contains(ch) == false)
                {
                    outValue += ch;
                    hs.Add(ch);
                }
            }
            return outValue;
        }
        static void Main(string[] args)
        {
            char[] first = "hello".ToCharArray();
            Console.WriteLine(RemoveDuplicate(first));

            Console.ReadKey();
        }
    }
}
/*
OUTPUT
helo
*/
