using System;

namespace Binary_Tree_Diameter
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
            public int TreeDepth()
            {
                return TreeDepth(root);
            }
            private int TreeDepth(Node curr)
            {
                if (curr == null)
                {
                    return 0;
                }
                else
                {
                    int leftDepth = TreeDepth(curr.leftChild);
                    int rightDepth = TreeDepth(curr.rightChild);

                    if (leftDepth > rightDepth)
                        return leftDepth + 1;
                    else
                        return rightDepth + 1;
                }
            }
            public int maxLengthPathBT()
            {
                return maxLengthPathBT(root);
            }
            private int maxLengthPathBT(Node curr) 
            {
                int max;

                int leftPath, rightPath;
                int leftMax, rightMax;

                if (curr == null)
                    return 0;

                leftPath = TreeDepth(curr.leftChild);
                rightPath = TreeDepth(curr.rightChild);

                max = leftPath + rightPath + 1;

                leftMax = maxLengthPathBT(curr.leftChild);
                rightMax = maxLengthPathBT(curr.rightChild);

                if(leftMax > max)
                {
                    max = leftMax;
                }
                if(rightMax > max)
                {
                    max = rightMax;
                }
                return max;
            }
        }
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            tree.CreateCompleteBinaryTree(arr);

            Console.WriteLine("Diameter of Binary Tree is : " + tree.maxLengthPathBT());

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Diameter of Binary Tree is : 6
*/
