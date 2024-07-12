using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Number_Is_Palindrome
{
    class Program
    {
        static bool checkPalindrome(string str)
        {
            int len = str.Length;

            for (int i = 0; i < len / 2; i++)
            {
                if (str[i] != str[len - i - 1])
                    return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            string str = "123409904321";

            if (checkPalindrome(str) == true)
                Console.WriteLine("It's a Palindrome !!");
            else
                Console.WriteLine("No, It's not a Palindrome !!");
        }
    }
}
