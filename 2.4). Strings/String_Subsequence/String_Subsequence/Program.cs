using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Subsequence
{
    class Program
    {
        static void printSubsequences(string input, string output)
        {
            if (input.Length == 0)
            {
                Console.WriteLine(output);
                return;
            }
            printSubsequences(input.Substring(1), output + input[0]);
            printSubsequences(input.Substring(1), output);
        }
        static void Main(string[] args)
        {
            string output = "";
            string input = "abcde";

            printSubsequences(input, output);
        }
    }
}
