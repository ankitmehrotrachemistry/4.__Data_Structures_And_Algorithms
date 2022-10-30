using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDeletion
{
    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int item)
        {
            data = item;
            left = right = null;
        }
    }

    class BinaryTreeDelete
    {
        public Node root;

        public virtual void deleteTree(Node node)
        {
            root = null;
        }

        static void Main(string[] args)
        {
            BinaryTreeDelete tree = new BinaryTreeDelete();

            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
            
            tree.deleteTree(tree.root);
            tree.root = null;
            Console.WriteLine("Tree deleted");
        }
    }
}
