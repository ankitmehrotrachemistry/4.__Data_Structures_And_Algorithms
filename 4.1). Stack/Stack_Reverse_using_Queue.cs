using System;
using System.Collections.Generic;

namespace Stack_Reverse_using_Queue
{
    class Program
    {
        public static void reverseStack2(Stack<int> stack)
        {
            Queue<int> queue = new Queue<int>();
            while(stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            while(queue.Count != 0)
            {
                stack.Push(queue.Dequeue());
            }
        }
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.Write("Elements of Stack are : ");

            foreach (var elem in stack)
                Console.Write(elem + " ");

            Console.WriteLine();

            reverseStack2(stack);

            Console.Write("Elements after reversal of Stack using Queue are : ");

            foreach (var elem in stack)
                Console.Write(elem + " ");

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Elements of Stack are : 4 3 2 1
Elements after reversal of Stack using Queue are : 1 2 3 4
*/
