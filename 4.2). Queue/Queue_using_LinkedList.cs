using System;

namespace Queue_using_LinkedList
{
    class Program
    {
        public class Queue
        {
            private Node tail = null;
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

            public int Size()
            {
                return count;
            }

            public bool Empty
            {
                get
                {
                    return count == 0;
                }
            }
            public void Add(int value)
            {
                Node temp = new Node(value, tail);

                if(tail == null)
                {
                    tail = temp;
                    tail.next = tail;
                }
                else
                {
                    temp.next = tail.next;
                    tail.next = temp;
                    tail = temp;
                }
                count++;
            }
            public int remove()
            {
                if(Empty)
                {
                    throw new System.InvalidOperationException("Stack Empty");
                }

                int value = 0;

                if(tail == tail.next)
                {
                    value = tail.value;
                    tail = null;
                }
                else
                {
                    value = tail.next.value;
                    tail.next = tail.next.next;
                }
                count--;
                return value;
            }

            public void Print()
            {
                if(Size() == 0)
                {
                    Console.Write("- Queue is Empty");
                    return;
                }
                Node temp = tail.next;

                Console.Write("- Queue Elements are : ");

                for(int i = 0; i < Size(); i++)
                {
                    Console.Write(temp.value + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
            public int Peek()
            {
                if(Empty)
                {
                    throw new System.InvalidOperationException("Stack Empty");
                }

                int value;
                if(tail == tail.next)
                {
                    value = tail.value;
                }
                else
                {
                    value = tail.next.value;
                }
                return value;
            }
        }
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Add(1);
            queue.Add(2);
            queue.Add(3);
            queue.Add(4);

            queue.Print();

            Console.WriteLine("- Is Queue Empty ? (True/False) : " + queue.Empty);

            Console.WriteLine("- Size of Queue is " + queue.Size());

            Console.Write("- Elements removed from Queue are : ");

            for (int i = 0; i < 3; i++)
            {
                Console.Write(queue.remove() + " ");
            }
            Console.WriteLine();

            queue.Print();

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
- Queue Elements are : 1 2 3 4
- Is Queue Empty ? (True/False) : False
- Size of Queue is 4
- Elements removed from Queue are : 1 2 3
- Queue Elements are : 4
*/
