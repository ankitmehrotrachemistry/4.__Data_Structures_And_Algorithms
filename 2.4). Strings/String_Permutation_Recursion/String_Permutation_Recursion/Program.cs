using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Permutation_Recursion
{
    class Program
    {
        static void permutation(String s, String answer)
        {
            if (s.Length == 0)
            {
                Console.Write(answer + " ");
                return;
            }
            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];

                string left_substr = s.Substring(0,i);
                String right_substr = s.Substring(i+1);

                String rest = left_substr + right_substr;

                permutation(rest, answer+ch);
            }
        }
        static void Main(string[] args)
        {
            String s;
            String answer = "";

            Console.Write("Enter the String : ");
            s = Console.ReadLine();

            Console.Write("All possible Strings are : ");
            permutation(s, answer);
        }
    }
}