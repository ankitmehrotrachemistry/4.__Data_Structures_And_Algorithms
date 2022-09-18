using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDeleteMid
{
    class Program
    {
        public class CreateList
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

            public class DeleteMid<T>
            {
                public int size;

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
                    size++;
                }

                public void deleteFromMid()
                {
                    Node<T> temp, current;

                    if (head == null)
                    {
                        Console.WriteLine("List is Empty");
                        return;
                    }
                    else
                    {
                        int count = (size % 2 == 0) ? (size / 2) : ((size + 1)/2);

                        if (head != tail)
                        {
                            temp = head;
                            current = null;

                            for (int i = 0; i < count - 1; i++)
                            {
                                current = temp;
                                temp = temp.next;
                            }
                            if (current != null)
                            {
                                current.next = temp.next;
                                temp = null;
                            }
                            else
                            {
                                head = tail = temp.next;

                                temp = null;
                            }
                        }
                        else
                        {
                            head = tail = null;
                        }
                    }
                    size--;
                }

                public void display()
                {
                    Node<T> current = head;
                    if (head == null)
                    {
                        Console.WriteLine("List is empty");
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
                DeleteMid<int> sList = new DeleteMid<int>();

                sList.addNode(1);
                sList.addNode(2);
                sList.addNode(3);
                sList.addNode(4);
                sList.addNode(5);

                Console.WriteLine("Original List is : ");
                sList.display();

                while (sList.head != null)
                {
                    sList.deleteFromMid();

                    Console.WriteLine("Updated List is : ");
                    sList.display();
                }
            }
        }
        
    }
}
