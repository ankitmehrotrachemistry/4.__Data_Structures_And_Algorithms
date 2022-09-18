// C# Program to check whether Key Value in present in Sorted list or Not!

using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListKeyValue
{
    class SortedListProgram
    {
        static void Main(string[] args)
        {
            SortedList PlayerList = new SortedList();

            Console.WriteLine("\nClash Royale Deck in ascending order of Elixer are:-\n");
            PlayerList.Add(7, "Pekka");
            PlayerList.Add(4, "Mini Pekka");
            PlayerList.Add(3, "Princess");
            PlayerList.Add(1, "Skeltons");
            PlayerList.Add(6, "Giant Skelton");
            PlayerList.Add(2, "Bats");
            PlayerList.Add(5, "Hogg Rider");


            foreach (DictionaryEntry pair in PlayerList)
            {
                Console.WriteLine("{0} and {1}", pair.Key, pair.Value);
            }

            Console.WriteLine("\nClash Royale Deck after RemoveAt() Method are:-\n");

            PlayerList.RemoveAt(4);

            foreach (DictionaryEntry pair in PlayerList)
            {
                Console.WriteLine("{0} and {1}", pair.Key, pair.Value);
            }


            if (PlayerList.Contains(7) == true)
            {
                Console.WriteLine("\nKey is Found");
            }
            else
            {
                Console.WriteLine("\nKey is not found");
            }

            if (PlayerList.ContainsKey(8) == true)
            {
                Console.WriteLine("\nKey is Found");
            }
            else
            {
                Console.WriteLine("\nKey is not found");
            }

            if (PlayerList.ContainsValue("Pekka") == true)
            {
                Console.WriteLine("\nValue is Found\n");
            }
            else
            {
                Console.WriteLine("\nValue is not found\n");
            }
        }
    }
}