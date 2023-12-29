using System;
using System.Collections.Generic;

namespace Binary_Tree_PrintSpiralTree
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

            public void PrintSpiralTree()
            {
                Stack<Node> stack1 = new Stack<Node>();
                Stack<Node> stack2 = new Stack<Node>();

                Node temp;

                if(root != null)
                {
                    stack1.Push(root);
                }

                while(stack1.Count != 0 || stack2.Count != 0)
                {
                    while(stack1.Count != 0)
                    {
                        temp = stack1.Pop();
                        Console.Write(" " + temp.value);

                        if(temp.rightChild != null)
                        {
                            stack2.Push(temp.rightChild);
                        }
                        if(temp.leftChild != null)
                        {
                            stack2.Push(temp.leftChild);
                        }
                    }

                    while (stack2.Count != 0)
                    {
                        temp = stack2.Pop();
                        Console.Write(" " + temp.value);

                        if (temp.leftChild != null)
                        {
                            stack1.Push(temp.leftChild);
                        }
                        if (temp.rightChild != null)
                        {
                            stack1.Push(temp.rightChild);
                        }
                        
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Binary Tree Elements Spiral Order using Stack are : ");

            tree.CreateCompleteBinaryTree(arr);

            tree.PrintSpiralTree();

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Binary Tree Elements Spiral Order using Stack are :
1 2 3 7 6 5 4 8 9 10
*/
