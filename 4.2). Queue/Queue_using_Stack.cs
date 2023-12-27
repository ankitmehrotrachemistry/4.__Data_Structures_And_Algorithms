using System;
using System.Collections.Generic;

namespace Queue_using_Stack
{
    class Program
    {
        public class Queue
        {
            private Node tail = null;
            private int size = 0;
            private class Node
            {
                internal int value;
                internal Node next;

                public Node(int value, Node next)
                {
                    this.value = value;
                    this.next = next;
                }
            }

            private Stack<int> stack1;
            private Stack<int> stack2;

            public Queue()
            {
                stack1 = new Stack<int>();
                stack2 = new Stack<int>();
            }

            internal void Add(int value)
            {
                stack1.Push(value);
            }

            internal int Remove()
            {
                int value;

                if(stack2.Count > 0)
                {
                    return stack2.Pop();
                }

                while(stack1.Count > 0)
                {
                    value = stack1.Pop();
                    stack2.Push(value);
                }
                return stack2.Pop();
            }
            public int Size()
            {
                return size;
            }
        }
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Add(1);
            queue.Add(2);
            queue.Add(3);
            queue.Add(4);
            queue.Add(5);

            Console.Write("Elements removed from Queue are : ");

            for (int i = 0; i < 2; i++)
            {
                Console.Write(queue.Remove() + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Elements removed from Queue are : 1 2
*/
