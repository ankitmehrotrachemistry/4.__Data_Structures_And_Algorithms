using System;
using System.Collections.Generic;

namespace Binary_Tree_LevelOrder_LineByLine2
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

            public void PrintLevelOrderLineByLine2()
            {
                Queue<Node> queue = new Queue<Node>();
                Node temp = null;
                int count = 0;

                if (root != null)
                {
                    queue.Enqueue(root);
                }

                while(queue.Count != 0)
                {
                    count = queue.Count;

                    while(queue.Count > 0)
                    {
                        temp = queue.Dequeue();
                        Console.Write(" " + temp.value);

                        if (temp.leftChild != null)
                        {
                            queue.Enqueue(temp.leftChild);
                        }
                        if (temp.rightChild != null)
                        {
                            queue.Enqueue(temp.rightChild);
                        }
                        count -= 1;
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Level Order Line by Line Binary Tree Elements using Queue are : ");

            tree.CreateCompleteBinaryTree(arr);

            tree.PrintLevelOrderLineByLine2();

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Level Order Line by Line Binary Tree Elements using Queue are :
 1 2 3 4 5 6 7 8 9 10
*/
