using System;

namespace LinkedListAddHead_NthNodeFromEnd
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
        public int NthNodeFromEnd(int index)
        {
            int size = FindLength();
            int startIndex;

            if(size != 0 && size < index)
            {
                return int.MaxValue;
            }
            startIndex = size - index + 1;
            return NthNodeFromBeginning(startIndex);
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
            Console.Write("4th Node From Beginning in LinkedList is : ");
            Console.WriteLine(linkedList.NthNodeFromBeginning(4));

            Console.Write("2nd Node From end in LinkedList is : ");
            Console.WriteLine(linkedList.NthNodeFromEnd(2));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
LinkedList after adding to head is : 4 3 2 1
4th Node From Beginning in LinkedList is : 1
2nd Node From end in LinkedList is : 2
*/
