// C# Program for Dictionary Add Operation

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace DictionarySample
{
    class DictionaryProgram
    {
        static void Main(string[] args)
        {
            Dictionary<string, Int16>PlayerList = new Dictionary<string, Int16>();

            PlayerList.Add("Sachin", 1);
            PlayerList.Add("Sehwag", 2);
            PlayerList.Add("Ganguly", 3);
            PlayerList.Add("Dhoni", 4);
            PlayerList.Add("Gambhir", 5);
            
            Console.WriteLine("Players List");

            foreach (KeyValuePair<string, Int16> player in PlayerList)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    player.Key, player.Value);
            }
            //Console.ReadKey();
        }
    }
}