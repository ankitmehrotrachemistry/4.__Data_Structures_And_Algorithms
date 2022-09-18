using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Reversal_Iterative
{
    class Program
    {
        static String Swap(String str, int i, int j)
        {
            char[] ch = str.ToCharArray();
            char temp = ch[i];
            ch[i] = ch[j];
            ch[j] = temp;

            return String.Join("", ch);
        }
        static String reverseString(String str)
        {
            int n = str.Length;

            for (int i = 0; i < n / 2; i++)
                str = Swap(str, i, n-i-1);

            return str;
        }
        static void Main(string[] args)
        {
            string str = "AnkitMehrotra";
            str = reverseString(str);
            Console.WriteLine(str);
        }
    }
}