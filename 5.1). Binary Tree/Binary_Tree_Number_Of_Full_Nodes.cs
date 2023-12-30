using System;

namespace Binary_Tree_Number_Of_Full_Nodes
{
    // A full node is a node that has both left and right child.
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
            public int numFullNodesBT()
            {
                return numFullNodesBT(root);
            }
            private int numFullNodesBT(Node curr)
            {
                int count;
                if(curr == null)
                {
                    return 0;
                }

                count = numFullNodesBT(curr.rightChild) + numFullNodesBT(curr.leftChild);

                if(curr.leftChild != null && curr.rightChild != null)
                {
                    count++;
                }
                return count;
            }
        }
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            tree.CreateCompleteBinaryTree(arr);

            Console.WriteLine("Number of Full Nodes in Binary Tree : " + tree.numFullNodesBT());

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Number of Full Nodes in Binary Tree : 4
*/
