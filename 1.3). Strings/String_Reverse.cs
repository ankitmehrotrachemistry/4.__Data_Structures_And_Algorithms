using System;

namespace String_Reverse
{
    class Program
    {
        public static string reverseString(string str)
        {
            char[] a = str.ToCharArray();
            reverseStringUtil(a);
            string expn = new string(a);
            return expn;
        }
        public static void reverseStringUtil(char[] a)
        {
            int lower = 0;
            int upper = a.Length - 1;

            char tempChar;
            while (lower < upper)
            {
                tempChar = a[lower];
                a[lower] = a[upper];
                a[upper] = tempChar;
                lower++;
                upper--;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Reversed string is : " + reverseString("ankit mehrotra"));
            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Reversed string is : artorhem tikna
*/
