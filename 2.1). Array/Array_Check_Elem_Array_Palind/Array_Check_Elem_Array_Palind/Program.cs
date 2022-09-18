using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Check_Elem_Array_Palind
{
    class Program
    {
        static bool isPalindrome(int N)
        {
            string str = "" + N;
            int len = str.Length;
            for (int i = 0; i < len / 2; i++)
            {
                if (str[i] != str[len - 1 - i])
                    return false;
            }
            return true;
        }

        static bool isPalindromeArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                bool ans = isPalindrome(arr[i]);
                if (ans == false)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[] arr = { 121, 131, 202 };
            int n = arr.Length;

            bool res = isPalindromeArray(arr,n);
            if (res == true)
                Console.WriteLine("Array is Palindrome");
            else
                Console.WriteLine("Array is not a Plaindrome");
        }
    }
}
