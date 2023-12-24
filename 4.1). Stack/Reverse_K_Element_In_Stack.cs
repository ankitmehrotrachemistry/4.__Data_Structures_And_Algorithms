using System;
using System.Collections.Generic;

namespace Reverse_K_Element_In_Stack
{
    class Program
    {
        // Top k elements will be reversed
        public static void reverseKElementInStack(Stack<int> stack, int k)
        {
            Queue<int> queue = new Queue<int>();
            int i = 0;

            while(stack.Count > 0 && i < k)
            {
                queue.Enqueue(stack.Pop());
                i++;
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

            reverseKElementInStack(stack, 3);

            Console.Write("Elements after reversal of K Elements are : ");

            foreach (var elem in stack)
                Console.Write(elem + " ");

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Elements of Stack are : 4 3 2 1
Elements after reversal of K Elements are : 2 3 4 1
*/
