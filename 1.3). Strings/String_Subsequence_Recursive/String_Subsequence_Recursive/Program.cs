using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Subsequence_Recursive
{
    class Program
    {
        public static void printSubsequenceRecursion(String str, int n, int index, String curr)
        {
            if (index == n)
            {
                return;
            }
            if (curr != null && !(curr.Trim().Length == 0))
            {
                Console.WriteLine(curr);
            }
            for (int i = index + 1; i < n; i++)
            {
                curr += str[i];
                Program.printSubsequenceRecursion(str, n, i, curr);

                curr = curr.Substring(0,curr.Length-1-0);
            }
        }

        public static void printSubseq(String str)
        {
            var index = -1;
            var curr = "";

            Program.printSubsequenceRecursion(str, str.Length, index, curr);
        }
        static void Main(string[] args)
        {
            var str = "abc";
            Program.printSubseq(str);
        }
    }
}
