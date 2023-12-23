using System;

namespace StackImplement_Array_PushPop
{
    class Program
    {
        public class Stack
        {
            private int capacity = 1000;
            private int[] data;
            private int top = -1;
            public Stack()
            {
                data = new int[capacity];
            }
            public Stack(int size)
            {
                data = new int[size];
                capacity = size;
            }
            public bool Empty
            {
                get
                {
                    return (top == -1);
                }
            }
            public int size()
            {
                return (top + 1);
            }
            public void Print()
            {
                for(int i = top; i > -1; i--)
                {
                    Console.Write(data[i] + " ");
                }
            }
            public void Push(int value)
            {
                if(size() == data.Length)
                {
                    throw new System.InvalidOperationException("Stack Overflow");
                }
                top++;
                data[top] = value;
            }
            public int Pop()
            {
                if(Empty)
                {
                    throw new System.InvalidOperationException("Stack Empty");
                }
                int topVal = data[top];
                top--;

                return topVal;
            }
            public int Peek()
            {
                if(Empty)
                {
                    throw new System.InvalidOperationException("Stack Empty");
                }
                return data[top];
            }
        }
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            Console.Write("Stack after Push Operation is : ");
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Print();
            Console.WriteLine();

            Console.Write("Stack after Pop Operation is : ");
            stack.Pop();
            stack.Print();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Stack after Push Operation is : 4 3 2 1
Stack after Pop Operation is : 3 2 1
*/
