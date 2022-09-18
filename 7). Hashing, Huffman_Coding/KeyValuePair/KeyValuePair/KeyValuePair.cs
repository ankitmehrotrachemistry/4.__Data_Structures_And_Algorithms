// C# Program for List Key Value Pair

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValuePair
{
    class KeyValuePair
    {
        static void Main(string[] args)
        {
            // Shows a List of KeyValuePairs.
            var list = new List<KeyValuePair<string, int>>();

            list.Add(new KeyValuePair<string, int>("Teacher", 1));
            list.Add(new KeyValuePair<string, int>("Student", 2));
            list.Add(new KeyValuePair<string, int>("Principle", 3));
            list.Add(new KeyValuePair<string, int>("Accountant", 4));

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

        }
    }
}
