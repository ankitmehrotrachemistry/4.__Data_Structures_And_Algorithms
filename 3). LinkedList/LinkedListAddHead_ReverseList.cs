using System;

namespace LinkedListAddHead_ReverseList
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

        public bool IsEmpty()
        {
            return size == 0;
        }
        public void AddHead(int value)
        {
            head = new Node(value, head);
            size++;
        }
        public void Reverse()
        {
            Node curr = head;
            Node prev = null;
            Node next = null;

            while(curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            head = prev;
        }
        public void print()
        {
            Node temp = head;

            while (temp != null)
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

            Console.Write("LinkedList after reversing Linked List is : ");
            linkedList.Reverse();

            linkedList.print();

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
LinkedList after adding to head is : 4 3 2 1
LinkedList after reversing Linked List is : 1 2 3 4
*/
