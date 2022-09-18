using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapBinaryMaxInsertion
{
    public class Node
    {
        public Node left;
        public Node right;
        public int key;
        public Node(int key)
        {
            this.key = key;
            left = null;
            right = null;
        }
    }
    class Program
    {
        public int size;
        public Node root;

        public Program()
        {
            root = null;
            size = 0;
        }
        public int insertHeight()
        {
            int i = 1;
            int sum = 0;
            while (this.size > sum + (1 << i))
            {
                sum += (1 << i);
                i++;
            }
            return i;
        }
        public void swapNode(Node first, Node second)
        {
            int key = first.key;
            first.key = second.key;
            second.key = key;
        }
        public void arrangeNode(Node root)
        {
            if (root.left != null && root.left.key > root.key)
            {
                swapNode(root, root.left);
            }
            if (root.right != null && root.right.key > root.key)
            {
                swapNode(root, root.right);
            }
        }
        public Boolean addNode(Node root, int height, int level, int key)
        {
            if (level >= height)
            {
                return false;
            }
            if (root != null)
            {
                if (level - 1 == height && root.left == null || root.right == null)
                {
                    if (root.left == null)
                    {
                        root.left = new Node(key);
                    }
                    else
                    {
                        root.right = new Node(key);
                    }
                    arrangeNode(root);
                    return true;
                }
                if (addNode(root.left, height, level + 1, key) ||
                    addNode(root.right, height, level + 1, key))
                {
                    arrangeNode(root);
                    return true;
                }
            }
            return false;
        }
        public void insert(int key)
        {
            if (root == null)
            {
                root = new Node(key);
            }
            else
            if (root.left == null)
            {
                root.left = new Node(key);
                arrangeNode(root);
            }
            else
            if (root.right == null)
            {
                root.right = new Node(key);
                arrangeNode(root);
            }
            else
            {
                int height = insertHeight();
                addNode(root, height, 0, key);
            }
            this.size++;
        }
        public void preorder(Node root)
        {
            if (root != null)
            {
                Console.Write(" " + root.key);
                preorder(root.left);
                preorder(root.right);
            }
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();

            p1.insert(5);
            p1.insert(7);
            p1.insert(4);
            p1.insert(3);
            p1.insert(9);
            p1.insert(14);
            p1.insert(2);
            p1.insert(1);
            p1.insert(6);
            p1.insert(11);

            p1.preorder(p1.root);

            Program p2 = new Program();

            for (int i = 15; i > 0; i--)
            {
                p2.insert(i);
            }
            Console.WriteLine();

            p2.preorder(p2.root);
        }
    }
}