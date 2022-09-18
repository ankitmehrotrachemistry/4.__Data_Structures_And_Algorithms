// C# Program of Singly Linked List
// Operations like Insertion, Deletion and Traversal

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singly_Linked_List
{
    class SinglyLinkedlist
    {
        private int data;
        private SinglyLinkedlist next;

        public SinglyLinkedlist() // Constructor
        {
            data = 0;
            next = null;
        }
        public SinglyLinkedlist(int value) // Overloading of Contructor
        {
            data = value;
            next = null;
        }

        public SinglyLinkedlist InsertNext(int value) // Insertion Operation
        {
            SinglyLinkedlist node = new SinglyLinkedlist(value);
            if (this.next == null)
            {
                node.next = null;
                this.next = node;
            }
            else
            {
                SinglyLinkedlist temp = this.next;
                node.next = temp;
                this.next = node;
            }
            return node;
        }

        public int DeleteNext() // Deletion Operation 
        {
            if (next == null)
                return 0;
            SinglyLinkedlist node = this.next;
            this.next = this.next.next;
            node = null;
            return 1;
        }

        public void TraverseList(SinglyLinkedlist node) // Traversal 
        {
            if (node == null)
                node = this;
            System.Console.WriteLine("\nTraversing the Singly LinkedList");
            while (node != null)
            {
                System.Console.WriteLine(node.data);
                node = node.next;
            }
        }
    }

    class Singly_Linked_List_Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedlist node1 = new SinglyLinkedlist(1);

            SinglyLinkedlist node2 = node1.InsertNext(2);
            SinglyLinkedlist node3 = node2.InsertNext(3);
            SinglyLinkedlist node4 = node3.InsertNext(4);
            SinglyLinkedlist node5 = node4.InsertNext(5);
            SinglyLinkedlist node6 = node5.InsertNext(6);
            SinglyLinkedlist node7 = node6.InsertNext(7);

            node1.TraverseList(null);

            Console.WriteLine("\nDeletion Operation done:-");

            node3.DeleteNext();

            Console.WriteLine("\nLinkedList after Deletion Operation:-");

            node2.TraverseList(null);

            //System.Console.ReadLine();
        }
    }
}