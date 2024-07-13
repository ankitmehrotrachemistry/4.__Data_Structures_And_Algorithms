// HashTable Example use of ICollection Interface

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable
{
    class HashTableExample
    {
        static void Main(string[] args)
        {
            Hashtable H = new Hashtable();

            H.Add("01", "Ankit");
            H.Add("02", "Arpit");
            H.Add("03", "Archit");
            H.Add("04", "Aakrit");
            H.Add("05", "Pulkit");
            H.Add("06", "Ankita");
            H.Add("07", "Arkita");

            if (H.ContainsValue("Sukriti"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                H.Add("08", "Sukriti");
            }

            // Get a collection of the keys.
            ICollection key = H.Keys;

            foreach (string s in key)
            {
                Console.WriteLine(s + ": " + H[s]);
            }
            Console.ReadKey();
        }
    }
}
