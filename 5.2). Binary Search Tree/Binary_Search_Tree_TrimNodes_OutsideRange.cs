using System;

namespace Binary_Search_Tree_TrimNodes_OutsideRange
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
            public void TrimOutsideRange(int min, int max)
            {
                TrimOutsideRange(root, min, max);
            }
            private Node TrimOutsideRange(Node curr, int min, int max)
            {
                if (curr == null)
                    return null;

                curr.leftChild = TrimOutsideRange(curr.leftChild, min, max);
                curr.rightChild = TrimOutsideRange(curr.rightChild, min, max);

                if (curr.value < min)
                    return curr.rightChild;

                if(curr.value > max)
                    return curr.leftChild;

                return curr;
            }
        }
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.Write("Binary Search Tree Inorder Traversal are : ");

            tree.CreateBinarySearchTree(arr);

            tree.PrintInOrder();

            tree.TrimOutsideRange(4,7);

            Console.Write("Trimmed Value of Binary Search Tree are : ");

            tree.PrintInOrder();

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Binary Search Tree Inorder Traversal are : 1 2 3 4 5 6 7 8 9 10
Trimmed Value of Binary Search Tree are : 4 5 6 7
*/
