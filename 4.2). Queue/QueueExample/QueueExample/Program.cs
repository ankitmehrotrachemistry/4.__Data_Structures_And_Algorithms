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
            Queue<string> student = new Queue<string>();

            student.Enqueue("Mark");
            student.Enqueue("Jack");
            student.Enqueue("Sarah");
            student.Enqueue("Smith");
            student.Enqueue("Robbie");
            print(student);

            Console.WriteLine("\nRemoving {0} from List. \nNew list is : ", student.Dequeue());
            print(student);

            string[] city = { "Newyork", "California", "Las Vegas" };
            Queue<string> citylist = new Queue<string>(city);
            Console.WriteLine("\nPrinting City List");
            print(citylist);

            Console.WriteLine("Count{0}", citylist.Count);
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
