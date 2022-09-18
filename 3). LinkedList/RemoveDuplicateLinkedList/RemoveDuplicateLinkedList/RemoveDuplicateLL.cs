using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateLinkedList
{
    class RemoveDuplicateLL
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        static void Main(string[] args)
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = Insert(head, data);
            }

            head = removeDuplicates(head);
            display(head);
            Console.ReadKey();
        }

        public static Node removeDuplicates(Node head)
        {
            if (head != null)
            {
                Node start = head;
                while (start != null)
                {
                    if (start.next != null && start.data == start.next.data)
                    {
                        start.next = start.next.next;
                    }
                    else
                    {
                        start = start.next;
                    }
                }
            }
            return head;
        }

        public static Node Insert(Node head, int data)
        {
            Node p = new Node(data);
            if (head == null)
            {
                head = p;
            }
            else if (head.next == null)
            {
                head.next = p;
            }
            else
            {
                Node start = head;
                while (start.next != null)
                {
                    start = start.next;
                }
                start.next = p;
            }
            return head;
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
    }
}
