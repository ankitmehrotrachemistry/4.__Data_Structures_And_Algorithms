using System;

namespace Binary_Tree_CopyTree
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
            public Tree CopyTree()
            {
                Tree tree = new Tree();
                tree.root = CopyTree(root);
                return tree;
            }
            private Node CopyTree(Node curr)
            {
                Node temp;

                if(curr != null)
                {
                    temp = new Node(curr.value);

                    temp.leftChild = CopyTree(curr.leftChild);
                    temp.rightChild = CopyTree(curr.rightChild);

                    return temp;
                }
                else
                {
                    return null;
                }
            }
        }
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            tree.CreateCompleteBinaryTree(arr);

            Tree tree2 = tree.CopyTree();

            Console.Write("Copy of Binary Tree is : ");

            tree2.PrintInOrder();

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Copy of Binary Tree is : 8 4 9 2 10 5 1 6 3 7
*/
