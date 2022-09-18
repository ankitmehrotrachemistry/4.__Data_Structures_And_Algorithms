using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapBinaryNew
{
    public class TreeNode
    {
        public int key;
        public int counter;

        public TreeNode sibling;
        public TreeNode parent;
        public TreeNode child;
        public TreeNode(int key, TreeNode sibling)
        {
            this.key = key;
            this.sibling = sibling;
            
            this.child = null;
            this.parent = null;
            this.counter = 0;
        }
    }
    class Program
    {
        public TreeNode root;

        public Program()
        {
            this.root = null;
        }
        public Boolean isCombine(TreeNode node)
        {
            if (node != null && node.sibling != null && node.counter == node.sibling.counter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public TreeNode changeRelation(TreeNode parentNode, TreeNode childNode)
        {
            if (parentNode.sibling == childNode)
            {
                parentNode.sibling = childNode.sibling;
            }
            childNode.sibling = parentNode.child;
            parentNode.child = childNode;
            childNode.parent = parentNode;
            parentNode.counter += 1;

            return parentNode;
        }
        public TreeNode merge(TreeNode node1, TreeNode node2)
        {
            TreeNode temp = null;

            if (node1.key < node2.key)
            {
                temp = changeRelation(node1, node2);
            }
            else
            {
                temp = changeRelation(node2, node1);
            }
            if (isCombine(temp) == true)
            {
                temp = merge(temp, temp.sibling);
            }
            return temp;
        }
        public void insert(int key)
        {
            //  Create new node of tree
            TreeNode node = new TreeNode(key, this.root);
            if (this.root == null)
            {
                //  When add subtree node
                this.root = node;
            }
            else if (isCombine(node) == true)
            {
                //  When need to combine two sibling
                this.root = merge(node, this.root);
            }
            else
            {
                this.root = node;
            }
        }
        public void printTree(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            Console.Write("  " + node.key);
            
            printTree(node.child);
            printTree(node.sibling);
        }
        public int minimum()
        {
            if (this.root == null)
            {
                return -1;
            }

            TreeNode auxiliary = this.root;
            int result = this.root.key;
            
            while (auxiliary != null)
            {
                if (result > auxiliary.key)
                {
                    result = auxiliary.key;
                }
                auxiliary = auxiliary.sibling;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Program tree = new Program();

            tree.insert(6);
            tree.insert(5);
            tree.insert(9);
            tree.insert(3);
            tree.insert(4);
            tree.insert(11);
            tree.insert(1);
            tree.insert(7);
            tree.insert(12);
            tree.insert(10);
            tree.insert(21);
            tree.insert(14);
            tree.insert(6);

            Console.Write("\n Constructing Binomial Heap \n");

            tree.printTree(tree.root);

            Console.Write("\n Mimimum Node : " +tree.minimum() + " ");
        }
    }
}