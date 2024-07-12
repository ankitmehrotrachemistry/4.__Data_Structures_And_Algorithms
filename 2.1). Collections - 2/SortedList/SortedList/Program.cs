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

            //creation of sortedlist

            SortedList<int, string> sortedlist = new SortedList<int, string>();

            //add the elements in sortedlist

            sortedlist.Add(1, "Sunday");

            sortedlist.Add(2, "Monday");

            sortedlist.Add(3, "Tuesday");

            sortedlist.Add(4, "Wednesday");

            sortedlist.Add(5, "Thusday");

            sortedlist.Add(6, "Friday");

            sortedlist.Add(7, "Saturday");

            //display the elements of the sortedlist

            Console.WriteLine("The elements in the SortedList are:");

            foreach (KeyValuePair<int, string> pair in sortedlist)

            {

                Console.WriteLine("{0} => {1}", pair.Key, pair.Value);

            }

            IList<int> ilistKeys = sortedlist.Keys;

            Console.WriteLine();

            Console.WriteLine("The keys are:");

            Console.Write("{");

            foreach (int i in ilistKeys)

            {

                Console.Write(i + ",");

            }

            Console.WriteLine("}");

        }

    }
}
