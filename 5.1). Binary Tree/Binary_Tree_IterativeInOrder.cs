using System;
using System.Collections.Generic;

namespace Binary_Tree_IterativeInOrder
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
            public void iterativeInOrder()
            {
                Stack<Node> stack = new Stack<Node>();
                Stack<int> visited = new Stack<int>();

                Node curr;
                int vstd;

                if(root != null)
                {
                    stack.Push(root);
                    visited.Push(0);
                }

                while(stack.Count > 0)
                {
                    curr = stack.Pop();
                    vstd =  visited.Pop();

                    if(vstd == 1)
                    {
                        Console.Write(curr.value + " ");
                    }
                    else
                    {
                        if (curr.rightChild != null)
                        {
                            stack.Push(curr.rightChild);
                            visited.Push(0);
                        }

                        stack.Push(curr);
                        visited.Push(1);

                        if (curr.leftChild != null)
                        {
                            stack.Push(curr.leftChild);
                            visited.Push(0);
                        }
                    }
                    
                }
            }
        }
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            tree.CreateCompleteBinaryTree(arr);

            Console.Write("Iterative InOrder Traversal of Binary Tree is : ");
            tree.iterativeInOrder();

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Iterative InOrder Traversal of Binary Tree is : 8 4 9 2 10 5 1 6 3 7
*/
