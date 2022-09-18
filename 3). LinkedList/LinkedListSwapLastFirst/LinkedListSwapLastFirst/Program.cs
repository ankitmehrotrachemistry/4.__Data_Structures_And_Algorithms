using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSwapLastFirst
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

        public class Swap<T>
        {
            public Node<T> head = null;

            public void addNode(T data)
            {
                Node<T> newNode = new Node<T>(data);

                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node<T> current = head;

                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = newNode;
                }
            }

            public void swapLastWithFirst()
            {
                Node<T> current = head, temp = null, index = null;

                if (head == null)
                {
                    return;
                }
                else
                {
                    while (current.next != null)
                    {
                        index = current;
                        current = current.next;
                    }

                    if (head == current)
                    {
                        return;
                    }
                    else if (head.next == current)
                    {
                        temp = head;
                        head = current;
                        head.next = temp;
                        temp.next = null;
                    }
                    else
                    {
                        temp = head;
                        head = current;
                        head.next = temp.next;
                        index.next = temp;
                        temp.next = null;
                    }
                }
            }
            public void Display()
            {
                Node<T> current = head;

                if (head == null)
                {
                    Console.WriteLine("List is Empty ");
                    return;
                }
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
            Swap<int> sList = new Swap<int>();

            sList.addNode(1);
            sList.addNode(2);
            sList.addNode(3);
            sList.addNode(4);
            sList.addNode(5);
            sList.addNode(6);
            sList.addNode(7);

            Console.WriteLine("Original List is : ");
            sList.Display();

            sList.swapLastWithFirst();

            Console.WriteLine("List after swapping last and first is : ");
            sList.Display();
        }
    }
}