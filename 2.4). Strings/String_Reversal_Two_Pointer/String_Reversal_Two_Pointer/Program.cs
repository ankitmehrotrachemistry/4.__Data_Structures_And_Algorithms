using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Reversal_Two_Pointer
{
    class Program
    {
        static void reverseString(String str)
        {
            int n = str.Length;

            char[] ch = str.ToCharArray();
            char temp;

            for (int i = 0, j = n - 1; i < j; i++, j--)
            {
                temp = ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
            }
            Console.WriteLine(ch);
        }
        static void Main(string[] args)
        {
            String str = "AnkitMehrotra";
            reverseString(str);
        }
    }
}
