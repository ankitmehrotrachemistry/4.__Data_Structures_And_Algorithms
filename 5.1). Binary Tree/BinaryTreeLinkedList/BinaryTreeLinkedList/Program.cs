using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeLinkedList
{
    class Program
    {
        public class Node<T>
        {
            public T data;
            public Node<T> left;
            public Node<T> right;

            public Node(T data)
            {
                this.data = data;
                this.left = null;
                this.right = null;
            }
        }

        public class BinaryTree<T>
        {
            public Node<T> root;

            public BinaryTree()
            {
                root = null;
            }

            public void insertNode(T data)
            {
                Node<T> newNode = new Node<T>(data);

                if (root == null)
                {
                    root = newNode;
                    return;
                }
                else
                {
                    Queue<Node<T>> queue = new Queue<Node<T>>();

                    queue.Enqueue(root);

                    while(true)
                    {
                        Node<T> node = queue.Dequeue();

                        if (node.left != null && node.right != null)
                        {
                            queue.Enqueue(node.left);
                            queue.Enqueue(node.right);
                        }
                        else
                        {
                            if (node.left == null)
                            {
                                node.left = newNode;
                                queue.Enqueue(node.left);
                            }
                            else
                            {
                                node.right = newNode;
                                queue.Enqueue(node.right);
                            }
                            break;
                        }
                    }
                }
            }

            public void inorderTraversal(Node<T> node)
            {
                if (root == null)
                {
                    Console.WriteLine("Tree is Empty");
                    return;
                }
                else
                {
                    if (node.left != null)
                        inorderTraversal(node.left);
                    Console.WriteLine(node.data + " ");

                    if (node.right != null)
                        inorderTraversal(node.right);
                }
            }
        }
        static void Main(string[] args)
        {
            BinaryTree<int> bt = new BinaryTree<int>();

            bt.insertNode(1);
            Console.WriteLine("Binary Tree after insertion is ");
            bt.inorderTraversal(bt.root);

            bt.insertNode(2);
            bt.insertNode(4);

            Console.WriteLine("\n Now, Binary Tree after insertion is ");

            bt.inorderTraversal(bt.root);

            bt.insertNode(5);
            bt.insertNode(6);

            Console.WriteLine("\n Then, Binary Tree after insertion is ");

            bt.inorderTraversal(bt.root);

            bt.insertNode(7);
            bt.insertNode(8);

            Console.WriteLine("\n In the end, Binary Tree after insertion is ");

            bt.inorderTraversal(bt.root);
        }
    }
}
