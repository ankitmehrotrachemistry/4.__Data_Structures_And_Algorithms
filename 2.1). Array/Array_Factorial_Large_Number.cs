using System;

namespace Array_Factorial_Large_Number
{
    class Program
    {
        static int Multiply(int x, int[] result, int result_size)
        {
            int carry = 0;

            for (int i = 0; i < result_size; i++)
            {
                int product = result[i] * x + carry;
                result[i] = product % 10;
                carry = product / 10;
            }

            while (carry != 0)
            {
                result[result_size] = carry % 10;
                carry = carry / 10;  // (eg. 45/10 = 4 but 4/10 = 0)
                result_size++;
            }
            return result_size;
        }

        static void Factorial(int n)
        {
            int[] resultFactorial = new int[500];

            resultFactorial[0] = 1;
            int result_size = 1;

            for (int x = 2; x <= n; x++)
                result_size = Multiply(x, resultFactorial, result_size);

            Console.WriteLine("Size is : " + result_size);

            Console.WriteLine("Factorial of Large Number is : ");
            for (int i = result_size - 1; i >= 0; i--)
                Console.Write(resultFactorial[i]);
        }
        static void Main(string[] args)
        {
            Factorial(100);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Size is : 158
Factorial of Large Number is :
93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000
*/
