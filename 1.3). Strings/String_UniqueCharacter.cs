using System;

namespace String_UniqueCharacter
{
    class Program
    {
        public static bool isUniqueChar(string str)
        {
            int[] bitArr = new int[26];
            int index;

            for (int i = 0; i < 26; i++)
                bitArr[i] = 0;

            int size = str.Length;

            for(int i = 0; i < size; i++)
            {
                char c = str[i];

                if ('A' <= c && 'Z' >= c)
                    index = (c - 'A');
                else if ('a' <= c && 'z' >= c)
                    index = (c - 'a');
                else
                {
                    Console.WriteLine("Unknown Char! \n");
                    return false;
                }

                if (bitArr[index] != 0)
                {
                    Console.WriteLine("Duplicate detected");
                    return false;
                }
                bitArr[index] += 1;
            }
            Console.WriteLine("No duplicate !");
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(isUniqueChar("glass"));
            Console.WriteLine(isUniqueChar("glas"));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Duplicate detected
False
No duplicate !
True
*/
