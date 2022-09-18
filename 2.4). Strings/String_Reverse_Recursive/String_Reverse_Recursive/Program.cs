using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Reverse_Recursive
{
    class Program
    {
        static char[] Swap(char[] arr, int i, int j)
        {
            char temp = arr[i];

            arr[i] = arr[j];
            arr[j] = temp;

            return arr;
        }

        static void recursiveReversal(char[] str, int i)
        {
            int n = str.Length;
            if (i == n / 2)
                return;
            Swap(str, i, n - i - 1);

            recursiveReversal(str, i+1);
        }
        static void Main(string[] args)
        {
            char[] str = "ankitMehrotra".ToCharArray();

            recursiveReversal(str, 0);

            Console.WriteLine(String.Join("", str));
        }
    }
}
