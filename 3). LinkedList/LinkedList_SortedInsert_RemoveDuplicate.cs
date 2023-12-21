using System;

namespace LinkedList_SortedInsert_RemoveDuplicate
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

        public void SortedInsert(int value)
        {
            Node newNode = new Node(value, null);
            Node curr = head;

            if(curr == null || curr.value > value)
            {
                newNode.next = head;
                head = newNode;
                return;
            }
            while(curr.next != null && curr.next.value < value)
            {
                curr = curr.next;
            }

            newNode.next = curr.next;
            curr.next = newNode;
        }

        public void RemoveDuplicate()
        {
            Node curr = head;

            while(curr != null)
            {
                if(curr.next != null && curr.value == curr.next.value)
                {
                    curr.next = curr.next.next;
                }
                else
                {
                    curr = curr.next;
                }
            }
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

            linkedList.SortedInsert(1);
            linkedList.SortedInsert(3);
            linkedList.SortedInsert(1);
            linkedList.SortedInsert(5);
            linkedList.SortedInsert(4);
            linkedList.SortedInsert(2);
            linkedList.SortedInsert(1);
            linkedList.SortedInsert(2);

            Console.Write("LinkedList after Insertion of Sorted Elements are : ");
            linkedList.print();

            Console.WriteLine();

            linkedList.RemoveDuplicate();
            Console.Write("LinkedList after Removing Duplicate Elements are : ");
            linkedList.print();

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
LinkedList after Insertion of Sorted Elements are : 1 1 1 2 2 3 4 5
LinkedList after Removing Duplicate Elements are : 1 2 3 4 5
*/
