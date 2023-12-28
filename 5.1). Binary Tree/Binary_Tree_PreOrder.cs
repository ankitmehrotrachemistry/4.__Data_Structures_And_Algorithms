using System;

namespace Binary_Tree_PreOrder
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

            public void PrintPreOrder()
            {
                PrintPreOrder(root);
                Console.WriteLine();
            }

            private void PrintPreOrder(Node node)
            {
                if (node != null)
                {
                    Console.Write(node.value + " ");
                    PrintPreOrder(node.leftChild);
                    PrintPreOrder(node.rightChild);
                }
            }

        }
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.Write("Binary Tree Elements in Preorder Traversal are : ");

            tree.CreateCompleteBinaryTree(arr);

            tree.PrintPreOrder();

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Binary Tree Elements in Preorder Traversal are : 1 2 4 8 9 5 10 3 6 7
*/
