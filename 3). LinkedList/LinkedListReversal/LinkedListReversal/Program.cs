using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListReversal
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
            public void reverse(Node<T> current)
            {
                if (head == null)
                {
                    Console.WriteLine("List is Empty");
                    return;
                }
                else
                {
                    if(current.next == null)
                    {
                        Console.Write(current.data + " ");
                        return;
                    }
                    reverse(current.next);
                    Console.Write(current.data + " ");
                }
            }

            public void Display()
            {
                Node<T> current = head;

                if (head == null)
                {
                    Console.WriteLine("List is Empty : ");
                    return;
                }

                while (current != null)
                {
                    Console.Write(current.data + "->");
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

            Console.WriteLine("Original List is : ");
            sList.Display();

            Console.WriteLine("Reversed List is : ");
            sList.reverse(sList.head);
        }
    }
}
