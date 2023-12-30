using System;

namespace Binary_Tree_Number_Of_Leaf_Nodes
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
            public int numLeafNodes()
            {
                return numLeafNodes(root);
            }
            private int numLeafNodes(Node curr)
            {
                if(curr == null)
                {
                    return 0;
                }
                if(curr.leftChild == null && curr.rightChild == null)
                {
                    return 1;
                }
                else
                {
                    return (numLeafNodes(curr.rightChild) + numLeafNodes(curr.leftChild));
                }
            }
        }
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            tree.CreateCompleteBinaryTree(arr);

            Console.WriteLine("Number of Leaf Nodes in Binary Tree : " + tree.numLeafNodes());

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Number of Leaf Nodes in Binary Tree : 5
*/
