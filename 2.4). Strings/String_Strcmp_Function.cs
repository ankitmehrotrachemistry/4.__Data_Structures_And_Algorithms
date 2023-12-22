using System;

namespace String_Strcmp_Function
{
    class Program
    {
        public static int Strcmp(string a, string b)
        {
            int index = 0;
            int len1 = a.Length;
            int len2 = b.Length;

            int minLen = len1;

            if (len1 > len2)
                minLen = len2;

            while (index < minLen && a[index] == b[index])
                index++;

        /*            
          a) The return value is 0 indicates that both first and second strings are equal.
          b) The return value is negative it indicates that the first string is less than the second string.
          c) The return value is positive it indicates that the first string is greater than the second string.
        */

            if (index == len1 && index == len2)
                return 0;
            else if (len1 == index)
                return -1;
            else if (len2 == index)
                return 1;
            else
                return a[index] - b[index];
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Strcmp("abcd","abcd"));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
0
*/
