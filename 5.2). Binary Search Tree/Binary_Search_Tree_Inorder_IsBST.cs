using System;

namespace Binary_Search_Tree_Inorder_IsBST
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

                if(start > end)
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
            private Node FindMinNode(Node curr)
            {
                Node node = curr;

                if(node == null)
                {
                    return null;
                }
                while(node.leftChild != null)
                {
                    node = node.leftChild;
                }
                return node;
            }
            private Node FindMaxNode(Node curr)
            {
                Node node = curr;

                if (node == null)
                {
                    return null;
                }
                while (node.rightChild != null)
                {
                    node = node.rightChild;
                }
                return node;
            }
            public bool isBST()
            {
                return isBST(root);
            }
            private bool isBST(Node root)
            {
                if(root == null)
                {
                    return true;
                }

                if(root.leftChild != null && FindMaxNode(root.leftChild).value > root.value)
                {
                    return false;
                }

                if (root.rightChild != null && FindMinNode(root.rightChild).value <= root.value)
                {
                    return false;
                }

                return (isBST(root.leftChild) && isBST(root.rightChild));
            }
        }
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.Write("Binary Search Tree Inorder Traversal are : ");

            tree.CreateBinarySearchTree(arr);

            tree.PrintInOrder();

            Console.WriteLine("The tree is Binary Search Tree or not (yes/no) : " + tree.isBST());
            
            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Binary Search Tree Inorder Traversal are : 1 2 3 4 5 6 7 8 9 10
The tree is Binary Search Tree or not (yes/no) : True
*/
