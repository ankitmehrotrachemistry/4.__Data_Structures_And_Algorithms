using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeMinNode
{
    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int d)
        {
            data = d;
            left = right = null;
        }
    }

    class Program
    {
        public static Node head;

        public virtual Node insert(Node node, int data)
        {
            if (node == null)
            {
                return (new Node(data));
            }
            else
            {
                if (data <= node.data)
                {
                    node.left = insert(node.left, data);
                }
                else
                {
                    node.right = insert(node.right, data);
                }

                return node;
            }
        }

        public virtual int minValue(Node node)
        {
            Node current = node;

            while (current.left != null)
            {
                current = current.left;
            }
            return (current.data);
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            Node root = null;

            root = p.insert(root, 4);

            p.insert(root, 2);
            p.insert(root, 1);
            p.insert(root, 5);
            p.insert(root, 8);
            p.insert(root, 7);

            Console.WriteLine("Minimum value of BST is " +p.minValue(root));

        }
    }
}
