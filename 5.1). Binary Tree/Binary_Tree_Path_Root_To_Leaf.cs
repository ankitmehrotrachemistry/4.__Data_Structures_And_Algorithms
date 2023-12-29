using System;
using System.Collections.Generic;

namespace Binary_Tree_Path_Root_To_Leaf
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
            public void printAllPath()
            {
                Stack<int> stack = new Stack<int>();
                printAllPathUtil(root, stack);
            }
            private void printAllPathUtil(Node curr, Stack<int> stack)
            {
                if(curr == null)
                {
                    return;
                }

                stack.Push(curr.value);

                if(curr.leftChild == null && curr.rightChild == null)
                {
                    foreach(int val in stack)
                    {
                        Console.Write(val + " ");
                    }
                    Console.WriteLine();
                    stack.Pop();
                    return;
                }

                printAllPathUtil(curr.rightChild, stack);
                printAllPathUtil(curr.leftChild, stack);
                stack.Pop();
            }

        }
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Binary Tree Elements printAllPath from Root to Leaf : ");

            tree.CreateCompleteBinaryTree(arr);

            tree.printAllPath();

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Binary Tree Elements printAllPath from Root to Leaf :
7 3 1
6 3 1
10 5 2 1
9 4 2 1
8 4 2 1
*/
