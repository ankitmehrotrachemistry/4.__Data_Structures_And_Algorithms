using System;

namespace Recursion_Sum_Of_N_Natural_Numbers
{
    class Program
    {
        int findSum(int n)
        {
            if (n != 0)
                return n + findSum(n - 1);
            else
                return n;
        }
        static void Main(string[] args)
        {
            int n, sum = 0;

            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());

            Program p = new Program();

            sum = p.findSum(n);

            Console.WriteLine("Sum of first " + n + " natural numbers = " + sum);
            Console.ReadKey();
        }
    }
}
