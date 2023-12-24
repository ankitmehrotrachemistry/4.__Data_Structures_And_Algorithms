using System;
using System.Collections.Generic;

namespace Stack_Reverse
{
    class Program
    {
        public static void BottomInsert<T>(Stack<T> stack, T value)
        {
            if (stack.Count == 0)
            {
                stack.Push(value);
            }
            else
            {
                T outVr = stack.Pop();
                BottomInsert(stack, value);
                stack.Push(outVr);
            }
        }
        public static void reverseStack<T>(Stack<T> stack)
        {
            if(stack.Count == 0)
            {
                return;
            }
            else
            {
                T value = stack.Pop();
                reverseStack(stack);
                BottomInsert(stack, value);
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

            reverseStack(stack);

            Console.Write("Elements after reversal of Stack are : ");

            foreach (var elem in stack)
                Console.Write(elem + " ");

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Elements of Stack are : 4 3 2 1
Elements after reversal of Stack are : 1 2 3 4
*/
