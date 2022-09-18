using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDeleteFirstNode
{
    class Node
    {
        public int data;
        public Node next;
    };

    class LinkedList
    {
        Node head;

        public LinkedList()
        {
            head = null;
        }

        public void push_back(int newElement)
        {
            Node newNode = new Node();

            newNode.data = newElement;
            newNode.next = null;

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = new Node();

                temp = head;

                while (temp.next != null)
                    temp = temp.next;
                temp.next = newNode;
            }
        }

        public void pop_front()
        {
            if (this.head != null)
            {
                Node temp = this.head;
                this.head = this.head.next;

                temp = null;
            }
        }

        public void PrintList()
        {
            Node temp = new Node();
            temp = this.head;

            if (temp != null)
            {
                Console.Write("The list contains : ");

                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The List is Empty");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList MyList = new LinkedList();

            MyList.push_back(10);
            MyList.push_back(20);
            MyList.push_back(30);
            MyList.push_back(40);
            MyList.push_back(50);

            MyList.PrintList();

            MyList.pop_front();

            MyList.PrintList();
        }
    }
}
