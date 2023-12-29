using System;

namespace Binary_Tree_NthPreOrder
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
            public void NthPreOrder(int index)
            {
                int[] counter = new int[] {0};
                NthPreOrder(root, index, counter);
            }
            private void NthPreOrder(Node node, int index, int[] counter)
            {
                if(node != null)
                {
                    counter[0]++;

                    if (counter[0] == index)
                    {
                        Console.Write(node.value);
                    }
                    NthPreOrder(node.leftChild, index, counter);
                    NthPreOrder(node.rightChild, index, counter);
                }
            }

        }
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.Write("Binary Tree Elements NthPreOrder : ");

            tree.CreateCompleteBinaryTree(arr);

            tree.NthPreOrder(2);

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Binary Tree Elements NthPreOrder : 2
*/
