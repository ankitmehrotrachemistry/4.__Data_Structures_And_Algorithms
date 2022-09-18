// C# Program to implement HashSet which does  not allow duplicate entry

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetDemo
{
    class HashSetProgram
    {
        static void Main(string[] args)
        {
            string[] name = new string[]
                {
                    "Ankit",
                    "Pulkit",
                    "Santosh",
                    "Gautam",
                    "Anubhav",
                    "Ankit"
                };

            Console.WriteLine("Length of Name of Array - " +name.Length + "\n");

            Console.WriteLine("Name of all Team Members are:-");
            foreach (var n in name)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\n");

            // HashSet Object which does  not allow duplicate entry

            HashSet<string> TeamNameSet = new HashSet<string>(name);

            Console.WriteLine("Total Number of Elements in HashSet are:- " +TeamNameSet.Count +"\n");

            Console.WriteLine("Name of all Team Members after removal of repeative Name are:-");

            foreach (var n in TeamNameSet)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\n");
        }
    }
}
