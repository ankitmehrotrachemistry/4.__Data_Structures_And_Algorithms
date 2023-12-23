using System;
using System.Collections.Generic;

namespace Stack_Insert_At_Bottom
{
    class Program
    {
        public static void BottomInsert(Stack<int> stack, int element)
        {
            int temp;

            if(stack.Count == 0)
            {
                stack.Push(element);
            }
            else
            {
                temp = stack.Pop();
                BottomInsert(stack, element);
                stack.Push(temp);
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

            BottomInsert(stack, 5);

            Console.Write("Elements of Stack after insertion at bottom are : ");

            foreach (var elem in stack)
                Console.Write(elem + " ");

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Elements of Stack are : 4 3 2 1
Elements of Stack after insertion at bottom are : 4 3 2 1 5
*/
