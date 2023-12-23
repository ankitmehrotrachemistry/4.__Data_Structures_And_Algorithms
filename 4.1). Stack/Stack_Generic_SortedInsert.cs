using System;
using System.Collections.Generic;

namespace Stack_Generic_SortedInsert
{
    class Program
    {
        public static void SortedInsert(Stack<int> stack, int element)
        {
            int temp;

            if (stack.Count == 0 || element > stack.Peek())
            {
                stack.Push(element);
            }
            else
            {
                temp = stack.Pop();
                SortedInsert(stack, element);
                stack.Push(temp);
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
            Console.WriteLine();

            Console.Write("Elements of Stack after insertion is : ");
            SortedInsert(stack, 5);
            foreach (var elem in stack)
                Console.Write(elem + " ");

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Elements of Stack are : 4 2 1 3
Elements of Stack after insertion is : 5 4 2 1 3
*/
