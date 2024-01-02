using System;

namespace Binary_Search_Tree_Inorder_Delete2
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
            private Node FindMinNode(Node node)
            {
                if (node == null)
                {
                    return null;
                }
                while (node.leftChild != null)
                {
                    node = node.leftChild;
                }
                return node;
            }
            public void Delete(int value)
            {
                root = Delete(root, value);
            }
            private Node Delete(Node node, int value)
            {
                if(node != null)
                {
                    if(node.value == value)
                    {
                        if(node.leftChild == null && node.rightChild == null)
                        {
                            return null;
                        }
                        else
                        {
                            if(node.leftChild == null) 
                            {
                                return node.rightChild;
                            }
                            if(node.rightChild == null)
                            {
                                return node.leftChild;
                            }
                            Node minNode = FindMinNode(node.leftChild);
                            int minValue = minNode.value;
                            node.value = minValue;
                            node.rightChild = Delete(node.rightChild, minValue);
                        }
                    }
                    else
                    {
                        if(node.value > value) 
                        {
                            node.leftChild = Delete(node.leftChild, value);
                        }
                        else
                        {
                            node.rightChild = Delete(node.rightChild, value);
                        }
                    }
                }
                return node;
            }
        }
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.Write("Binary Search Tree Inorder Traversal are : ");

            tree.CreateBinarySearchTree(arr);

            tree.PrintInOrder();

            Console.Write("Binary Search Tree Inorder Traversal after deletion are : ");

            tree.Delete(2);

            tree.PrintInOrder();

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Binary Search Tree Inorder Traversal are : 1 2 3 4 5 6 7 8 9 10
Binary Search Tree Inorder Traversal after deletion are : 1 1 3 4 5 6 7 8 9 10
*/
