using System;

namespace LinkedListAddHead_RecursiveCompareList
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
        
        public bool compareList(LinkedList list1)
        {
            return compareList(head, list1.head);
        }
        private bool compareList(Node head1, Node head2)
        {
            if(head1 == null && head2 == null)
            {
                return true;
            }
            else if((head1 == null) || (head2 == null) || (head1.value != head2.value))
            {
                return false;
            }
            else
            {
                return compareList(head1.next, head2.next);
            }
        }
        public LinkedList CopyList()
        {
            Node headNode = null;
            Node tailNode = null;
            Node tempNode = null;
            Node curr = head;

            if (curr == null)
            {
                return null;
            }

            headNode = new Node(curr.value, null);
            tailNode = headNode;
            curr = curr.next;

            while (curr != null)
            {
                tempNode = new Node(curr.value, null);
                tailNode.next = tempNode;
                tailNode = tempNode;
                curr = curr.next;
            }

            LinkedList linkedList = new LinkedList();
            linkedList.head = headNode;

            return linkedList;
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

            LinkedList linkedList2 = linkedList.CopyList();

            Console.Write("LinkedList Comparison : " + linkedList.compareList(linkedList2));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
LinkedList after adding to head is : 4 3 2 1
LinkedList Comparison : True
*/
