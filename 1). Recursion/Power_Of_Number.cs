using System;

namespace Recursion_Power_Of_Number
{
    class Program
    {
        public static int CalculatePower(int x, int y)
        {
            if (y == 0)
                return 1;
            else
                return x * CalculatePower(x, y - 1);
        }
        static void Main(string[] args)
        {
            int baseValue, exponentValue;
            int result;

            Console.WriteLine("Calculate Power of Number");

            Console.Write("Enter the Base Value : ");
            baseValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Exponent : ");
            exponentValue = Convert.ToInt32(Console.ReadLine());

            result = CalculatePower(baseValue, exponentValue);

            Console.Write("The value of {0} to power of {1} is : {2} ", baseValue, exponentValue, result);

            Console.ReadKey();
        }
    }
}
