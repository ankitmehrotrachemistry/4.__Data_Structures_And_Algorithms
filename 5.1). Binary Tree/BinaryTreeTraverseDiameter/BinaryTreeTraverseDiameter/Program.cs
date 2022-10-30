using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeTraverseDiameter
{
    class Node
    {
        public string data;
        public Node left, right;

        public Node(string item)
        {
            data = item;
            left = right = null;
        }
    }

    class MyBinaryTree
    {
        Node root;

        int diameter(Node root)
        {
            if (root == null)
                return 0;

            int lheight = height(root.left);
            int rheight = height(root.right);

            int ldiameter = diameter(root.left);
            int rdiameter = diameter(root.right);

            return Math.Max(lheight + rheight + 1,
                            Math.Max(ldiameter, rdiameter));
        }

        int diameter()
        {
            return diameter(root);
        }

        static int height(Node node)
        {
            if (node == null)
                return 0;

            return (1 + Math.Max(height(node.left), height(node.right)));
        }
        static bool TraverseAndAdd(List<Char> location, Node parentNode, string value)
        {
            if (location.Count > 0)
            {
                if (location.ElementAt(0) == 'L' && parentNode.left == null)
                {
                    parentNode.left = new Node(value);
                    return true;
                }
                else if (location.ElementAt(0) == 'R' && parentNode.right == null)
                {
                    parentNode.right = new Node(value);
                }
                else if (location.ElementAt(0) == 'L')
                {
                    location.RemoveAt(0);
                    TraverseAndAdd(location, parentNode.left, value);
                }
                else
                {
                    location.RemoveAt(0);
                    TraverseAndAdd(location, parentNode.right, value);
                }

                return true;
            }
            else
                return true;
        }

        static string PreorderTraversal(Node root)
        {
            if (root == null)
                return "";

            Console.WriteLine(root.data); ;

            if (root.left != null)
            {
                PreorderTraversal(root.left);
            }
            if (root.right != null)
            {
                PreorderTraversal(root.right);
            }
            return "";
        }
        static string InorderTraversal(Node root)
        {
            if (root == null)
                return "";

            if (root.left != null)
            {
                InorderTraversal(root.left);
                Console.WriteLine(root.data);
            }
            else if (root.left == null)
            {
                Console.WriteLine(root.data);
            }
            if (root.right != null)
            {
                InorderTraversal(root.right);
            }
            return "";
        }

        static string PostorderTraversal(Node root)
        {
            if (root == null)
                return "";

            if (root.left != null)
            {
                PostorderTraversal(root.left);
            }
            if (root.right != null)
            {
                PostorderTraversal(root.right);
                Console.WriteLine(root.data);
            }
            else
                Console.WriteLine(root.data);
            if (root.left == null && root.right == null)
            {
                Console.WriteLine(root.data);
            }
            return "";
        }

        public static void Main(String[] args)
        {
            MyBinaryTree tree = new MyBinaryTree();
            tree.root = new Node("12");
            tree.root.left = new Node("7");
            tree.root.right = new Node("17");
            tree.root.left.left = new Node("1");
            tree.root.left.right = new Node("5");

            string nodeloc = null;
            string nodeinputval = null;

            PostorderTraversal(tree.root);
            Console.Read();
        }
    }

}
