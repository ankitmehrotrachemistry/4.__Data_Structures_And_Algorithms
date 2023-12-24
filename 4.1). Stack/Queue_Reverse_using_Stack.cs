using System;
using System.Collections.Generic;

namespace Reverse_Queue_using_Stack
{
    class Program
    {
        public static void reverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();
            
            while(queue.Count != 0)
            {
                stack.Push(queue.Dequeue());
            }

            while(stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.Write("Elements of Queue are : ");

            foreach (var elem in queue)
                Console.Write(elem + " ");

            Console.WriteLine();

            reverseQueue(queue);

            Console.Write("Elements after reversal of Queue : ");

            foreach (var elem in queue)
                Console.Write(elem + " ");

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Elements of Queue are : 1 2 3 4
Elements after reversal of Queue : 4 3 2 1
*/
