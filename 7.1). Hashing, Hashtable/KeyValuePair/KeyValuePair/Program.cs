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
            list.Add(new KeyValuePair<string, int>("Cat", 1));
            list.Add(new KeyValuePair<string, int>("Dog", 2));
            list.Add(new KeyValuePair<string, int>("Rabbit", 4));

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
