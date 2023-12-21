using System;

namespace LinkedListAddHead_AddTail
{
    public class LinkedList
    {
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

        private Node head;

        private int size = 0;

        public int Size()
        {
            return size;
        }

        public void AddHead(int value)
        {
            head = new Node(value, head);
            size++;
        }

        public void AddTail(int value)
        {
            Node newNode = new Node(value, null);
            Node curr = head;

            if(head == null)
            {
                head = newNode;
            }

            while(curr.next != null)
            {
                curr = curr.next;
            }
            curr.next = newNode;
        }

        public int FindLength()
        {
            Node curr = head;
            int count = 0;

            while(curr != null)
            {
                count++;
                curr = curr.next;
            }
            return count;
        }

        public void print()
        {
            Node temp = head;

            while(temp != null)
            {
                Console.Write(temp.value + " ");
                temp = temp.next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            linkedList.AddHead(1);
            linkedList.AddHead(2);
            linkedList.AddHead(3);
            linkedList.AddHead(4);

            Console.Write("LinkedList after adding to head is : ");
            linkedList.print();

            Console.WriteLine();
            Console.WriteLine("Size of LinkedList is : " +linkedList.Size());
            Console.WriteLine("Or Size of LinkedList is : " +linkedList.FindLength());

            linkedList.AddTail(5);
            Console.Write("LinkedList after adding to Tail is : ");
            linkedList.print();

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
LinkedList after adding to head is : 4 3 2 1
Size of LinkedList is : 4
Or Size of LinkedList is : 4
LinkedList after adding to Tail is : 4 3 2 1 5
*/
