using System;

namespace Binary_Search_Tree_LeastCommonAncestor
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
            public bool Find(int value)
            {
                Node curr = root;

                while (curr != null)
                {
                    if (curr.value == value)
                    {
                        return true;
                    }
                    else if (curr.value > value)
                    {
                        curr = curr.leftChild;
                    }
                    else
                    {
                        curr = curr.rightChild;
                    }
                }
                return false;
            }
            public int LCABST(int first, int second)
            {
                int result;

                if(first > second)
                {
                    result = LCABST(root, second, first);
                }
                else
                {
                    result = LCABST(root, first, second);
                }

                if(result == int.MaxValue)
                {
                    Console.WriteLine("LCA not exists");
                }
                else
                {
                    Console.WriteLine("LCA is : " + result);
                }
                return result;
            }
            private int LCABST(Node curr, int first, int second) 
            {
                if(curr == null)
                {
                    return int.MaxValue;
                }
                if(curr.value > second)
                {
                    return LCABST(curr.leftChild, first, second);
                }
                if(curr.value < first)
                {
                    return LCABST(curr.rightChild, first, second);
                }

                if(Find(first) && Find(second))
                {
                    return curr.value;
                }

                return int.MaxValue;
            }
        }
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.Write("Binary Search Tree Inorder Traversal are : ");

            tree.CreateBinarySearchTree(arr);

            tree.PrintInOrder();

            Console.WriteLine("Least Common Ancestor is : " + tree.LCABST(1, 4));
            
            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Binary Search Tree Inorder Traversal are : 1 2 3 4 5 6 7 8 9 10
LCA is : 2
Least Common Ancestor is : 2
*/
