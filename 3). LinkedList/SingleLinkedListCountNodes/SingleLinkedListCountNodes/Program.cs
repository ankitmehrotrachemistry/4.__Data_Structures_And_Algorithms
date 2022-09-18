using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListCountNodes
{
    class Program
    {
        public class Node<T>
        {
            public T data;
            public Node<T> next;

            public Node(T value)
            {
                data = value;
                next = null;
            }
        }

        public class SinglyLinkedList<T>
        {
            public Node<T> head = null;
            public Node<T> tail = null;

            public void addNode(T data)
            {
                Node<T> newNode = new Node<T>(data);

                if (head == null)
                {
                    head = newNode;
                    tail = newNode;
                }
                else
                {
                    tail.next = newNode;
                    tail = newNode;
                }
            }

            public int countNodes()
            {
                int count = 0;

                Node<T> current = head;

                while (current != null)
                {
                    count++;
                    current = current.next;
                }

                return count;
            }

            public void display()
            {
                Node<T> current = head;

                if (head == null)
                {
                    Console.WriteLine("Empty List");
                    return;
                }

                Console.WriteLine("Nodes of Singly Linked List are : ");

                while (current != null)
                {
                    Console.Write(current.data + " ");
                    current = current.next;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            SinglyLinkedList<int> sList = new SinglyLinkedList<int>();

            sList.addNode(1);
            sList.addNode(2);
            sList.addNode(3);
            sList.addNode(4);
            sList.addNode(5);

            sList.display();

            Console.WriteLine("Count of Nodes in the List is : " +sList.countNodes());
        }
    }
}
