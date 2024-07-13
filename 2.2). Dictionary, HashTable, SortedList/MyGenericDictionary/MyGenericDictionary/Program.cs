// C# Program for Dictionary Key-Value Pair

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGenericDictionary
{
    public class GenericDictionary
    {
        static void Main(string[] args)
        {
            //Declare Generic Collection
            Dictionary<string, string> game = new Dictionary<string, string>();

            //Adding Item in Collection
            game.Add("Quiz", "Quizz Up");
            game.Add("Stealth", "IGI");
            game.Add("RogueLike", "Nethack");
            game.Add("Real-Time Strategy", "Age of Empires");
            game.Add("Tower Defence", "Clash Royale");
            
            Console.WriteLine(game["Stealth"]);
            
            foreach (KeyValuePair<string, string> items in game)
            {
                Console.WriteLine(items.ToString());
            }
            if (game.ContainsKey("Stealth"))
            {
                Console.WriteLine("\nKey found. Value is " + game["Stealth"]+"\n");
            }
            else
            {
                Console.WriteLine("\nKey Not Found\n");
            }
        }
    }
}
