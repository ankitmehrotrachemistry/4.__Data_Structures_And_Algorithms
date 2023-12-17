using System;

namespace Recursion_Factorial_Of_Number
{
    class Program
    {
        private static long CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;

            return n * CalculateFactorial(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Factorial of Number using Recursion : ");

            Console.Write("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            long factNumber = CalculateFactorial(num);
            Console.WriteLine("Fcatorial of Number {0} is : {1}", num, factNumber);

            Console.ReadKey();
        }
    }
}
