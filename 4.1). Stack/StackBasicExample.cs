// Push Elements on Stack

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBasicExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>(); // Push Integer Elements on Stack
            
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);

            foreach (var itm in myStack)
                Console.WriteLine(itm);
        }
    }
}