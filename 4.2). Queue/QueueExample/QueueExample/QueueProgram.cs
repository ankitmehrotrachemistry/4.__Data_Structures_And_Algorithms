// C# program of Queue and operations lime Enqueue() , Dequeue()

// Cricket Tournaments with Players 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    class QueueProgram
    {
        static void Main(string[] args)
        {
            Queue<string> Player = new Queue<string>();

            Player.Enqueue("Jadeja");
            Player.Enqueue("Sachin");
            Player.Enqueue("Sehwag");
            Player.Enqueue("Kohli");
            Player.Enqueue("Dhoni");

            print(Player);

            Console.WriteLine("\n\nRemoving {0} from List. \n  New list is : ", Player.Dequeue()); // Queue follows FIFO(First In First Out)
            print(Player); 

            string[] Tournament = { "T20", "IPL", "ICC", "Asia Cup"};

            Queue<string> tournamentlist = new Queue<string>(Tournament);

            Console.WriteLine("\n\nTournament List\n");
            print(tournamentlist);
            
        }
        public static void print(Queue<string> q)
        {
            foreach (string s in q)
            {
                Console.Write(s.ToString() + " | ");
            }
        }
    }
}
