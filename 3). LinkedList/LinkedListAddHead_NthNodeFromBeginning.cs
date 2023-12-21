using System;

namespace LinkedListAddHead_NthNodeFromBeginning
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
        public int NthNodeFromBeginning(int index)
        {
            if(index > Size() || index < 1)
            {
                return int.MaxValue;
            }
            int count = 0;
            Node curr = head;

            while(curr != null && count < index - 1)
            {
                count++;
                curr = curr.next;
            }
            return curr.value;
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
            Console.Write("Nth Node From Beginning in LinkedList is : ");

            Console.WriteLine(linkedList.NthNodeFromBeginning(2));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
LinkedList after adding to head is : 4 3 2 1
Nth Node From Beginning in LinkedList is : 3
*/
