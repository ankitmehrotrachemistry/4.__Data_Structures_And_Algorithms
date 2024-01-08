using System;

namespace Binary_Search_Tree_CeilBST
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
            public int CeilBST(double val)
            {
                Node curr = root;
                int ceil = int.MinValue;

                while (curr != null) 
                {
                    if(curr.value == val)
                    {
                        ceil = curr.value;
                        break;
                    }
                    else if(curr.value > val)
                    {
                        ceil = curr.value;
                        curr = curr.leftChild;
                    }
                    else
                    {
                        curr = curr.rightChild;
                    }
                }
                return ceil;
            }
        }
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.Write("Binary Search Tree Inorder Traversal are : ");

            tree.CreateBinarySearchTree(arr);

            tree.PrintInOrder();

            Console.Write("Ceil Value of Binary Search Tree is : " + tree.CeilBST(5.5));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Binary Search Tree Inorder Traversal are : 1 2 3 4 5 6 7 8 9 10
Ceil Value of Binary Search Tree is : 6
*/
