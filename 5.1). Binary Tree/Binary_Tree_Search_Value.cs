using System;

namespace Binary_Tree_Search_Value
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
            public bool searchBT(int value)
            {
                return searchBTUtil(root, value);
            }
            private bool searchBTUtil(Node curr, int value)
            {
                bool left, right;

                if(curr == null)
                {
                    return false;
                }
                if(curr.value == value)
                {
                    return true;
                }

                left = searchBTUtil(curr.leftChild, value);
                if(left)
                {
                    return true;
                }

                right = searchBTUtil(curr.rightChild, value);
                if(right)
                {
                    return true;
                }
                return false;
            }
        }
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            tree.CreateCompleteBinaryTree(arr);

            Console.WriteLine("Search Value in Binary Tree : " + tree.searchBT(2));
            Console.WriteLine("Search Value in Binary Tree : " + tree.searchBT(12));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Search Value in Binary Tree : True
Search Value in Binary Tree : False
*/
