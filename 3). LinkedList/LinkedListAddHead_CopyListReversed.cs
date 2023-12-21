using System;

namespace LinkedListAddHead_CopyListReversed
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
        public LinkedList CopyListReversed()
        {
            Node tempNode = null;
            Node tempNode2 = null;
            
            Node curr = head;

            while(curr != null)
            {
                tempNode2 = new Node(curr.value, tempNode);
                curr = curr.next;
                tempNode = tempNode2;
            }

            LinkedList linkedList2 = new LinkedList();
            linkedList2.head = tempNode;

            return linkedList2;
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

            LinkedList linkedList1 = linkedList.CopyListReversed();
            Console.Write("LinkedList after copying Reversed Linked List is : ");
            
            linkedList.print();

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
LinkedList after adding to head is : 4 3 2 1
LinkedList after copying Reversed Linked List is : 4 3 2 1
*/
