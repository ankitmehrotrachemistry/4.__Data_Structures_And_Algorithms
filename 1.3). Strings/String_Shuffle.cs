using System;

namespace String_Shuffle
{
    class Program
    {
        public static string shuffle(string str)
        {
            char[] arr = str.ToCharArray();
            int n = arr.Length / 2;
            int count = 0;
            int k = 1;
            char temp = '\0';

            for(int i = 1; i < n; i+= 2)
            {
                temp = arr[i];
                k = i;
                do
                {
                    k = (2 * k) % (2 * n - 1);

                    char temp2 = temp;
                    temp = arr[k];
                    arr[k] = temp2;

                    count++;

                } while (i != k);

                if (count == (2 * n - 2))
                    break;
            }
            string st = new string(arr);
            Console.WriteLine(st);
            
            return st;
        }
        static void Main(string[] args)
        {
            Console.Write("String after shuffling is : ");
            shuffle("ABCDEFGH12345678");
            Console.ReadKey();
        }
    }
}

/*
OUTPUT
String after shuffling is : A1B2C3D4E5F6G7H8
*/
