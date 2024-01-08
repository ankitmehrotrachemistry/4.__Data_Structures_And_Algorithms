using System;
using System.Collections.Generic;

// Given an array of integers, you need to find if it
// represents a PreOrder traversal of binary search tree.

namespace Binary_Search_Tree_IsBSTArray
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
            public void CreateBinarySearchTree(int[] arr)
            {
                root = CreateBinarySearchTree(arr, 0, arr.Length - 1);
            }
            private Node CreateBinarySearchTree(int[] arr, int start, int end)
            {
                Node curr = null;

                if (start > end)
                {
                    return null;
                }

                int mid = (start + end) / 2;

                curr = new Node(arr[mid]);

                curr.leftChild = CreateBinarySearchTree(arr, start, mid - 1);
                curr.rightChild = CreateBinarySearchTree(arr, mid + 1, end);

                return curr;
            }

            public void PrintInOrder()
            {
                PrintInOrder(root);
                Console.WriteLine();
            }
            private void PrintInOrder(Node node)
            {
                if (node != null)
                {
                    PrintInOrder(node.leftChild);
                    Console.Write(node.value + " ");
                    PrintInOrder(node.rightChild);
                }
            }
            public bool IsBSTArray(int[] preorder)
            {
                int size = preorder.Length;
                Stack<int> stack = new Stack<int>();
                int value;
                int root = -999999;

                for(int i = 0; i < size; i++)
                {
                    value = preorder[i];

                    // If value of right child is less than root

                    if(value < root)
                    {
                        return false;
                    }

                    // First left child value will be popped
                    // Last popped value is root.

                    while(stack.Count > 0 && stack.Peek() < value)
                    {
                        root = stack.Pop();
                    }

                    // Add current value to the stack.
                    stack.Push(value);
                }
                return true;
            }
        }
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.Write("Binary Search Tree Inorder Traversal are : ");

            tree.CreateBinarySearchTree(arr);

            tree.PrintInOrder();

            int[] arr1 = new int[] { 5, 2, 4, 6, 9, 10 };
            int[] arr2 = new int[] { 5, 2, 6, 4, 7, 9, 10 };

            Console.WriteLine("Is Binary Search Tree Array ? " + tree.IsBSTArray(arr1));
            Console.WriteLine("Is Binary Search Tree Array ? " + tree.IsBSTArray(arr2));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Binary Search Tree Inorder Traversal are : 1 2 3 4 5 6 7 8 9 10
Is Binary Search Tree Array ? True
Is Binary Search Tree Array ? False
*/
