using System;
using System.Collections.Generic;

namespace Stack_Generic
{
    class Program
    {
        public static void SortStack2(Stack<int> stack)
        {
            int temp;

            Stack<int> stack1 = new Stack<int>();

            while(stack.Count > 0)
            {
                temp = stack.Pop();
                while((stack1.Count > 0) && (stack1.Peek() < temp))
                {
                    stack.Push(stack1.Pop());
                }
                stack1.Push(temp);
            }

            while(stack1.Count > 0)
            {
                stack.Push(stack1.Pop());
            }
        }
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(3);
            stack.Push(1);
            stack.Push(2);
            stack.Push(4);

            Console.Write("Elements of Stack are : ");
            foreach (var elem in stack)
                Console.Write(elem + " ");

            SortStack2(stack);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Elements of Stack are : 4 2 1 3
*/
