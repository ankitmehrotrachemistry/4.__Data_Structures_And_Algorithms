using System;

namespace String_Power_Function
{
    class Program
    {
        public static int pow(int x, int n)
        {
            int value;

            if (n == 0)
                return 1;

            else if(n% 2 == 0)
            {
                value = pow(x, n / 2);
                return (value * value);
            }
            else
            {
                value = pow(x, n/2);
                return (x * value * value);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("The value of power is : " + pow(5,2));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
The value of power is : 25
*/
