using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionary1
{
    class SortedDictionaryProgram
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> sorteddictionary = new SortedDictionary<int, string>();

            sorteddictionary.Add(1, "January");

            sorteddictionary.Add(2, "Feburary");

            sorteddictionary.Add(3, "March");

            sorteddictionary.Add(4, "April");

            sorteddictionary.Add(5, "May");

            sorteddictionary.Add(6, "June");

            sorteddictionary.Add(7, "July");

            sorteddictionary.Add(8, "August");

            sorteddictionary.Add(9, "September");

            sorteddictionary.Add(10, "October");

            sorteddictionary.Add(11, "November");

            sorteddictionary.Add(12, "December");

            foreach (KeyValuePair<int, string> pair in sorteddictionary)

            {
                Console.WriteLine("{0},{1}", pair.Key, pair.Value);
            }

            sorteddictionary.Remove(10);

            sorteddictionary.Remove(11);

            sorteddictionary.Remove(12);

            Console.WriteLine("After removal the keys the sorteddictionary is as.");

            foreach (KeyValuePair<int, string> pair in sorteddictionary)

            {
                Console.WriteLine("{0},{1}", pair.Key, pair.Value);
            }

        }

    }

}
