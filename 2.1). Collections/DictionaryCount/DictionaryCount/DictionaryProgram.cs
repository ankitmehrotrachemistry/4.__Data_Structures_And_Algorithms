// C# Program to implement Sorted Dictionary

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace DictionaryCount
{
    class DictionaryProgram
    {
        static void Main(string[] args)
        {
            StringDictionary S = new StringDictionary();

            S.Add("A", "Apple");
            S.Add("B", "Ball");
            S.Add("C", "Cat");
            S.Add("D", "Dog");
            S.Add("E", "Elephant");

            Console.Write("Total Number of Key/Value Pairs in StringDictionary are :-" + S.Count + "\n");
        }
    }
}
