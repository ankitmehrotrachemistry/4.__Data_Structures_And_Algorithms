using System;

namespace String_Print_Anagram
{
    class Program
    {
        public static void printAnagram(string str)
        {
            char[] a = str.ToCharArray();
            int n = a.Length;
            printAnagram(a,n,n);
        }
        public static void printAnagram(char[] a, int max, int n)
        {
            if (max == 1)
                Console.WriteLine(a);

            char temp;

            for(int i = -1; i < max - 1; i++)
            {
                if(i != -1)
                {
                    temp = a[i];
                    a[i] = a[max - 1];
                    a[max - 1] = temp;
                }
                printAnagram(a, max - 1, n);
                if(i != -1)
                {
                    temp = a[i];
                    a[i] = a[max - 1];
                    a[max - 1] = temp;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("The anagram is : ");
            printAnagram("123");
            Console.ReadKey();
        }
    }
}

/*
OUTPUT
The anagram is :
123
213
321
231
132
312
*/
