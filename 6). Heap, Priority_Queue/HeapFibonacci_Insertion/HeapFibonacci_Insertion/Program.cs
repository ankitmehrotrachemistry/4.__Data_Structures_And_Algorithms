using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapFibonacci_Insertion
{
    public class HeapNode
    {
        public HeapNode left;
        public HeapNode right;
        public int key;
        public HeapNode(int value)
        {
            this.key = value;
            this.left = null;
            this.right = null;
        }
    }
    class Program
    {
        private int size;
        private HeapNode root;
        public Program()
        {
            this.root = null;
            this.size = 0;
        }

        public void Insert(int value)
        {
            HeapNode node = new HeapNode(value);

            node.left = node;
            node.right = node;

            if (this.root == null)
            {
                this.root = node;
            }
            else
            {
                this.root.left.right = node;

                node.right = this.root;
                node.left = this.root.left;

                this.root.left = node;

                if (this.root.key > node.key)
                {
                    this.root = node;
                }
            }
            this.size++;
        }

        public void Display()
        {
            if (this.root == null)
            {
                Console.WriteLine("Empty Tree");
            }
            else
            {
                Console.Write(" " + this.root.key);

                HeapNode head = this.root.right;

                while(head != null && head != this.root)
                {
                    Console.Write(" " +head.key);

                    head = head.right;
                }
            }
        }
        public int totalNode()
        {
            return this.size;
        }
        static void Main(string[] args)
        {
            Program heap = new Program();

            heap.Insert(5);
            heap.Insert(7);
            heap.Insert(4);
            heap.Insert(3);
            heap.Insert(9);
            heap.Insert(14);
            heap.Insert(2);
            heap.Insert(1);
            heap.Insert(6);
            heap.Insert(11);

            Console.Write("\n Total Nodes are : " +heap.totalNode() + "\n");

            heap.Display();
        }
    }
}
