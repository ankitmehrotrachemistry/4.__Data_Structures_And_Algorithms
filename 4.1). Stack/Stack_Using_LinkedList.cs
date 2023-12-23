using System;

namespace Stack_Using_LinkedList
{
    class Program
    {
        public class Stack
        {
            private Node head = null;
            private int count = 0;
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
            public int size()
            {
                return count;
            }
            public bool IsEmpty
            {
                get
                {
                    return count == 0;
                }
            }
            public int Peek()
            {
                if(IsEmpty)
                {
                    throw new System.InvalidOperationException("Stack Empty");
                }
                return head.value;
            }
            public void Push(int value)
            {
                head = new Node(value, head);
                count++;
            }
            public int Pop()
            {
                if(IsEmpty)
                {
                    throw new System.InvalidOperationException("Stack Empty");
                }
                int value = head.value;
                head = head.next;
                count--;

                return value;
            }
            public void insertAtBottom(int value)
            {
                if(IsEmpty)
                {
                    Push(value); ;
                }
                else
                {
                    int temp = Pop();
                    insertAtBottom(value);
                    Push(temp);
                }
            }
            public void Print()
            {
                Node temp = head;
                while(temp != null)
                {
                    Console.Write(temp.value + " ");
                    temp = temp.next;
                }
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
