using System;

namespace LinkedListAddHead_RemoveHead
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

        public bool IsEmpty()
        {
            return size == 0;
        }
        public void addHead(int value)
        {
            head = new Node(value, head);
            size++;
        }
        public int removeHead()
        {
            if(IsEmpty())
            {
                throw new System.InvalidOperationException("Empty List");
            }

            int value = head.value;
            head = head.next;
            size--;

            return value;
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

            linkedList.addHead(1);
            linkedList.addHead(2);
            linkedList.addHead(3);
            linkedList.addHead(4);

            Console.Write("LinkedList after adding to head is : ");
            linkedList.print();

            Console.WriteLine();
            Console.WriteLine("Size of LinkedList is : " +linkedList.Size());
            Console.WriteLine("Or Size of LinkedList is : " +linkedList.FindLength());

            linkedList.removeHead();
            Console.Write("LinkedList after removing from head is : ");
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
LinkedList after removing from head is : 3 2 1
*/
