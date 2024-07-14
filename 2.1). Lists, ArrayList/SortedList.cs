// C# Program of SortedList

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class KVPList
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sortedlist = new SortedList<int, string>();

            sortedlist.Add(1, "Sunday");
            sortedlist.Add(7, "Saturday");
            sortedlist.Add(4, "Wednesday");
            sortedlist.Add(2, "Monday");
            sortedlist.Add(6, "Friday");
            sortedlist.Add(3, "Tuesday");
            sortedlist.Add(5, "Thusday");
            
            
            Console.WriteLine("The elements in the SortedList are:");

            foreach (KeyValuePair<int, string> pair in sortedlist)
            {
                Console.WriteLine("{0} (KEY) => {1} (VALUE)", pair.Key, pair.Value);
            }

            // The SortedList class implements the IEnumerable, ICollection, IDictionary and ICloneable interfaces.

            IList<int> ilistKeys = sortedlist.Keys;

            Console.WriteLine("\nThe keys are:");

            Console.Write("{");

            foreach (int i in ilistKeys)
            {
                Console.Write(i + ",");
            }

            Console.WriteLine("}");

            Console.ReadKey();
        }
    }
}