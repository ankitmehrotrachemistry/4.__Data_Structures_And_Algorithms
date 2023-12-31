using System;
using System.Collections.Generic;

// Given a binary tree find if it is a complete tree.
// We perform breadth first traversal of tree using a queue.
// If we get a node that does not have left child then it
// cannot have right child too. In general, if we have any
// node which does not have both the child then it is not
// possible for any other node in breadth first traversal
// to have any child.

namespace Binary_Tree_CompleteTree
{
    class Program
    {
        public class Tree
        {
            private Node root;
            private class Node
            {
                internal int value;
                internal Node leftChild;
                internal Node rightChild;

                public Node(int value, Node leftChild, Node rightChild)
                {
                    this.value = value;
                    this.leftChild = leftChild;
                    this.rightChild = rightChild;
                }

                public Node(int value)
                {
                    this.value = value;
                    leftChild = null;
                    rightChild = null;
                }
            }
            public Tree()
            {
                root = null;
            }
            public void CreateCompleteBinaryTree(int[] arr)
            {
                root = CreateCompleteBinaryTree(arr, 0);
            }
            private Node CreateCompleteBinaryTree(int[] arr, int start)
            {
                int size = arr.Length;
                Node curr = new Node(arr[start]);

                int left = 2 * start + 1;
                int right = 2 * start + 2;

                if (left < size)
                {
                    curr.leftChild = CreateCompleteBinaryTree(arr, left);
                }
                if (right < size)
                {
                    curr.rightChild = CreateCompleteBinaryTree(arr, right);
                }
                return curr;
            }
            public bool isCompleteTree()
            {
                Queue<Node> queue = new Queue<Node>();

                Node temp = null;

                int noChild  = 0;

                if(root != null)
                {
                    queue.Enqueue(root);
                }
                while (queue.Count > 0) 
                {
                    temp = queue.Dequeue();

                    if(temp.leftChild != null)
                    {
                        if(noChild == 1)
                        {
                            return false;
                        }
                        queue.Enqueue(temp.leftChild);
                    }
                    else
                    {
                        noChild = 1;
                    }

                    if (temp.rightChild != null)
                    {
                        if (noChild == 1)
                        {
                            return false;
                        }
                        queue.Enqueue(temp.rightChild);
                    }
                    else
                    {
                        noChild = 1;
                    }
                }
                return true;
            }
        }
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            tree.CreateCompleteBinaryTree(arr);

            Console.Write("Is Tree Complete ? " + tree.isCompleteTree());

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Is Tree Complete ? True
*/
