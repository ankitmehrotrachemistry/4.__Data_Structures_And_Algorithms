using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Positive_To_Negative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            Console.WriteLine("Enter Elements : ");
            for(int i = 0; i < 5; i++)
            {
                array[i] = Convert.ToInt16(Console.ReadLine());
                
                if (array[i] > 0)
                    array[i] = -array[i];
            }
            Console.WriteLine("Elements after negation are : ");

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}
