using System;

namespace String_ToUpper_ToLower
{
    class Program
    {
        public static char ToUpper(char s)
        {
            if (s >= 97 && s <= (97 + 25))
                s = (char)(s - 32);

            return s;
        }
        public static char ToLower(char s)
        {
            if (s >= 65 && s <= (65 + 25))
                s = (char)(s + 32);

            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Uppercase to Lowercase is : " + ToLower('A'));
            Console.WriteLine("Lowercase to Uppercase is : " + ToUpper('a'));
            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Uppercase to Lowercase is : a
Lowercase to Uppercase is : A
*/
