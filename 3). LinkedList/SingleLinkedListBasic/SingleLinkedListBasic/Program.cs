using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListBasic
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

            public void display()
            {
                Node<T> current = head;

                if (head == null)
                {
                    Console.WriteLine("Empty List");
                    return;
                }

                Console.WriteLine("Nodes of Singly Linked List is : ");

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
            SinglyLinkedList<int> singleList = new SinglyLinkedList<int>();

            singleList.addNode(1);
            singleList.addNode(2);
            singleList.addNode(3);
            singleList.addNode(4);
            singleList.addNode(5);

            singleList.display();
        }
    }
}
