// LinkedList Class Program to implement Count, Remove, AddFirst, AddAfter Operation in C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListClass
{
    class LinkedListProgram
    {
        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            linkedList.AddLast("1");
            linkedList.AddLast("2");
            linkedList.AddLast("3");
            linkedList.AddLast("4");
            linkedList.AddLast("5");
            linkedList.AddLast("6");
            linkedList.AddLast("7");
            linkedList.AddLast("8");

            Console.WriteLine("Total Number of Nodes in LinkedList are:- " + linkedList.Count +"\n");

            Console.WriteLine("The Linked List is:- ");

            foreach (string str in linkedList)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("\n");

            linkedList.Remove("5");

            linkedList.AddFirst("0");

            LinkedListNode<string> nodeafter = linkedList.Find("7");
            linkedList.AddAfter(nodeafter, "44");

            Console.WriteLine("The Linked List after AddFirst, Remove and AddAfter Operation is:- ");

            foreach (string str in linkedList)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("\n");

            Console.WriteLine("Total Number of Nodes in LinkedList are:- " + linkedList.Count +"\n");

        }
    }
}
