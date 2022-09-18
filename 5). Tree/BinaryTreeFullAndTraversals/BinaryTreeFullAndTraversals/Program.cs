using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeFullAndTraversals
{
    class Program
    {
        public class TreeNode
        {
            public int data;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int data)
            {
                this.data = data;
                this.left = null;
                this.right = null;
            }
        }
        public class BinaryTree
        {
            public TreeNode root;

            public BinaryTree()
            {
                this.root = null;
            }
            public void inOrder(TreeNode node)
            {
                if (node != null)
                {
                    this.inOrder(node.left);

                    // Print node value

                    Console.Write("  " + node.data);
                    this.inOrder(node.right);
                }
            }

            public void preOrder(TreeNode node)
            {
                if (node != null)
                {
                    // Print node value

                    Console.Write("  " + node.data);
                    this.preOrder(node.left);
                    this.preOrder(node.right);
                }
            }

            public void postOrder(TreeNode node)
            {
                if (node != null)
                {
                    this.postOrder(node.left);
                    this.postOrder(node.right);

                    //Print node value

                    Console.Write("  " + node.data);
                }
            }

            public TreeNode fullBinaryTree(int[] arr, int size, int location)
            {
                if (location >= size)
                {
                    return null;
                }

                var head = new TreeNode(arr[location]);

                // build left subtree
                head.left = this.fullBinaryTree(arr, size, (location * 2) + 1);

                // build right subtree
                head.right = this.fullBinaryTree(arr, size, (location * 2) + 2);

                return head;
            }
        }
        static void Main(string[] args)
        {
            var tree = new BinaryTree();

            int[] arr = {1,2,3,4,5,6,7,8,9};

            var size = arr.Length;

            tree.root = tree.fullBinaryTree(arr, size, 0);

            Console.WriteLine("\n Inorder Data is : ");
            tree.inOrder(tree.root);

            Console.WriteLine("\n Pre-order Data is : ");
            tree.preOrder(tree.root);

            Console.WriteLine("\n Post-Order Traversal is : ");
            tree.postOrder(tree.root);
        }
    }
}
