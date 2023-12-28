using System;
using System.Collections.Generic;

namespace Binary_Tree_Depth_First_Stack
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

            public void PrintDepthFirst()
            {
                Stack<Node> stack = new Stack<Node>();

                if(root != null)
                {
                    stack.Push(root);
                }

                while(stack.Count > 0)
                {
                    Node temp = stack.Pop();

                    Console.Write(temp.value + " ");

                    if(temp.leftChild != null)
                    {
                        stack.Push(temp.leftChild);
                    }
                    if(temp.rightChild != null)
                    {
                        stack.Push(temp.rightChild);
                    }
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.Write("Depth First Search Binary Tree Elements using Stack are : ");

            tree.CreateCompleteBinaryTree(arr);

            tree.PrintDepthFirst();

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Depth First Search Binary Tree Elements using Stack are : 1 3 7 6 2 5 10 4 9 8
*/
