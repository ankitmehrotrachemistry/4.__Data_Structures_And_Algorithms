using System;

namespace String_Palindrome_OrNot
{
    class Program
    {
        public static bool isPalindrome(string str)
        {
            int i = 0;
            int j = str.Length - 1;

            while(i < j && str[i] == str[j])
            {
                i++;
                j--;
            }

            if(i < j)
            {
                Console.WriteLine("String is not a Palindrome");
                return false;
            }
            else
            {
                Console.WriteLine("String is Palindrome");
                return true;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(isPalindrome("hello"));
            Console.WriteLine(isPalindrome("eoloe"));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
String is not a Palindrome
False
String is Palindrome
True
*/
