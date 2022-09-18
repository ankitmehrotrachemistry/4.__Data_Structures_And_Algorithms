using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapMinMergeTwo
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
        public int insert_height()
        {
            int i = 1;
            int sum = 0;
            while (this.size > sum + (1 << i))
            {
                sum += (1<<i);
                i++;
            }
            return i;
        }
        public void swap_node(Node first, Node second)
        {
            int key = first.key;
            first.key = second.key;
            second.key = key;
        }
        public void arrange_node(Node root)
        {
            if (root.left != null && root.left.key < root.key)
            {
                swap_node(root, root.left);
            }
            if (root.right != null && root.right.key < root.key)
            {
                swap_node(root, root.right);
            }
        }
        public Boolean add_node(Node root, int height, int level, Node newNode)
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
                        root.left = newNode;
                    }
                    else
                    {
                        root.right = newNode;
                    }
                    arrange_node(root);
                    return true;
                }
                if (add_node(root.left, height, level + 1, newNode) || add_node(root.right, height, level + 1, newNode))
                {
                    arrange_node(root);
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
                arrange_node(root);
            }
            else
            if (root.right == null)
            {
                root.right = new Node(key);
                arrange_node(root);
            }
            else
            {
                int height = insert_height();
                Node newNode = new Node(key);
                add_node(root, height, 0, newNode);
            }
            this.size++;
        }
        public Node combine(Program first, Program second, Node root)
        {
            if (root != null)
            {
                root.left = combine(first, second, root.left);
                root.right = combine(first, second, root.right);
                if (root.left == null && root.right == null)
                {
                    int height = first.insert_height();
                    add_node(first.root, height, 0, root);
                    first.size++;
                    second.size--;
                    return null;
                }
            }
            return root;
        }
        public void merge(Program heap2)
        {
            if (this.root != null && heap2.root != null)
            {
                if (this.size > heap2.size)
                {
                    Console.Write("\n\n Merging of heap 2 in heap 1 ");
                    //add node element in first tree
                    heap2.root = combine(this, heap2, heap2.root);
                }
                else
                {
                    Console.Write("\n\n Merging of heap 1 in heap 2 ");
                    //add node element in second tree
                    this.root = combine(heap2, this, this.root);
                }
            }
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
        public void inorder(Node root)
        {
            if (root != null)
            {
                inorder(root.left);
                Console.Write(" " + root.key);
                inorder(root.right);
            }
        }
        public void postorder(Node root)
        {
            if (root != null)
            {
                postorder(root.left);
                postorder(root.right);
                Console.Write(" " + root.key);
            }
        }

        public void print_nodes()
        {
            Console.Write("\nPreorder : \n");
            preorder(this.root);

            Console.Write("\nInorder : \n");
            inorder(this.root);

            Console.Write("\nPostorder : \n");
            postorder(this.root);
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();

            p1.insert(8);
            p1.insert(10);
            p1.insert(14);
            p1.insert(13);
            p1.insert(11);
            p1.insert(12);

            Program p2 = new Program();

            for (int i = 7; i > 0; i--)
            {
                p2.insert(i);
            }

            Console.Write("First heap element : \n");
            p1.print_nodes();

            Console.Write("\n\nSecond heap element : \n");
            p2.print_nodes();

            Console.Write("\n After Merges ");
            p1.merge(p2);

            if (p1.root != null)
            {
                Console.Write("\n\nFirst heap element : ");
                p1.print_nodes();
            }

            if (p2.root != null)
            {
                Console.Write("\n\nSecond heap element : \n");
                p2.print_nodes();
            }
        }
    }
}