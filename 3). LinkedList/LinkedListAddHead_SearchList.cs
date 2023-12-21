using System;

namespace LinkedListAddHead_SearchList
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
        public void addHead(int value)
        {
            head = new Node(value, head);
            size++;
        }
        public bool SearchList(int data)
        {
            Node temp = head;

            while (temp != null)
            {
                if(temp.value == data)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
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

            linkedList.addHead(1);
            linkedList.addHead(2);
            linkedList.addHead(3);
            linkedList.addHead(4);

            Console.Write("LinkedList after adding to head is : ");
            linkedList.print();

            Console.WriteLine();

            Console.WriteLine("Search LinkedList Element : " + linkedList.SearchList(2));
            
            Console.ReadKey();
        }
    }
}

/*
OUTPUT
LinkedList after adding to head is : 4 3 2 1
Search LinkedList Element : True
*/
