using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_Reverse_Of_String
{
    class Program
    {
        public static string StringReverse(string str)
        {
            if (str.Length > 0)
                return str[str.Length - 1] + StringReverse(str.Substring(0, str.Length - 1));
            else
                return str;
        }
        static void Main(string[] args)
        {
            string str;

            Console.WriteLine("Get reverse of string : ");

            Console.Write("Input the string : ");
            str = Console.ReadLine();
            str = StringReverse(str);

            Console.Write("Reverse of string is : ");
            Console.WriteLine(str);
        }
    }
}
