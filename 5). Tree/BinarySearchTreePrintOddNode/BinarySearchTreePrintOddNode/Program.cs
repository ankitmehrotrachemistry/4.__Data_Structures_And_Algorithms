using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreePrintOddNode
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
    public class Program
    {
        public TreeNode root;

        public Program()
        {
            this.root = null;
        }

        public void addNode(int value)
        {
            var node = new TreeNode(value);

            if (node != null)
            {
                if (this.root == null)
                {
                    this.root = node;
                }
                else
                {
                    var find = this.root;

                    while (find != null)
                    {
                        if (find.data >= value)
                        {
                            if (find.left == null)
                            {
                                find.left = node;
                                return;
                            }
                            else
                            {
                                find = find.left;
                            }
                        }
                        else
                        {
                            find = find.right;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("\n Memory Overflow");
            }
        }

        public void printOddNode(TreeNode node)
        {
            if (node != null)
            {
                this.printOddNode(node.left);
                if (node.data % 2 != 0)
                {
                    Console.Write(" " +node.data);
                }

                this.printOddNode(node.right);
            }
        }
        static void Main(string[] args)
        {
            var tree = new Program();

            tree.addNode(5);
            tree.addNode(3);
            tree.addNode(9);
            tree.addNode(1);
            tree.addNode(4);
            tree.addNode(8);
            tree.addNode(11);
            tree.addNode(-3);
            tree.addNode(2);
            tree.addNode(6);
            tree.addNode(12);

            tree.printOddNode(tree.root);
        }
    }
}
