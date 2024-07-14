using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeInsertionLevelOrder
{
    class Program
    {
        public class Node
        {
            public int key;
            public Node left, right;

            public Node(int key)
            {
                this.key = key;

                left = null;
                right = null;
            }
        }

        static Node root;

        static void inorder(Node temp)
        {
            if (temp == null)
                return;

            inorder(temp.left);
            Console.Write(temp.key + " ");
            inorder(temp.right);
        }

        static void insert(Node temp, int key)
        {
            if (temp == null)
            {
                root = new Node(key);
                return;
            }

            Queue<Node> q = new Queue<Node>();
            q.Enqueue(temp);

            while (q.Count != 0)
            {
                temp = q.Peek();
                q.Dequeue();

                if (temp.left == null)
                {
                    temp.left = new Node(key);
                    break;
                }
                else
                    q.Enqueue(temp.left);

                if (temp.right == null)
                {
                    temp.right = new Node(key);
                    break;
                }
                else
                    q.Enqueue(temp.right);
            }
        }
        static void Main(string[] args)
        {
            root = new Node(10);

            root.left = new Node(11);
            root.left.left = new Node(7);

            root.right = new Node(9);
            root.right.left = new Node(15);
            root.right.right = new Node(8);

            Console.WriteLine("Inorder Traversal before Insertion");
            inorder(root);

            int key = 12;
            insert(root, key);

            Console.WriteLine("Inorder Traversal after Insertion");
            inorder(root);
        }
    }
}
