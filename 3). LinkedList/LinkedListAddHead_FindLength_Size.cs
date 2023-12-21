using System;

namespace LinkedListAddHead_FindLength_Size
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

            Console.WriteLine("Length of Linked List is : " + linkedList.FindLength());

            Console.WriteLine("Size of Linked List is : " + linkedList.Size());

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
LinkedList after adding to head is : 4 3 2 1
Length of Linked List is : 4
Size of Linked List is : 4
*/
