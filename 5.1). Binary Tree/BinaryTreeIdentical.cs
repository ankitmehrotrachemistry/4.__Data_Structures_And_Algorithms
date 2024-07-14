//C# Program to check Two Binary Tree are identical or not!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Level Order Traversal , We Require 2 Queues

namespace BinaryTreeIdentical
{
    class BinaryTreeIdentical
    {
        class Node
        {
            public int data;
            public Node left, right;
        }

        static bool areIdentical(Node root1, Node root2)
        {
            if (root1 == null && root2 == null)
                return true;
            
            if (root1 == null || root2 == null)
                return false;
            
            Queue<Node> q1 = new Queue<Node>();
            Queue<Node> q2 = new Queue<Node>();
            
            q1.Enqueue(root1);
            q2.Enqueue(root2);

            while (q1.Count != 0 && q2.Count != 0)
            {
                Node n1 = q1.Peek();
                Node n2 = q2.Peek();

                if (n1.data != n2.data)
                    return false;
                
                q1.Dequeue();
                q2.Dequeue();
                
                if (n1.left != null && n2.left != null)
                {
                    q1.Enqueue(n1.left);
                    q2.Enqueue(n2.left);
                }
 
                else if (n1.left != null || n2.left != null)
                    return false;
 
                if (n1.right != null && n2.right != null)
                {
                    q1.Enqueue(n1.right);
                    q2.Enqueue(n2.right);
                }
                else if (n1.right != null || n2.right != null)
                    return false;
            }

            return true;
        }

        static Node newNode(int data)
        {
            Node temp = new Node();
            temp.data = data;
            temp.left = null;
            temp.right = null;
            return temp;
        }

        static void Main(string[] args)
        {
            Node root1 = newNode(1);
            root1.left = newNode(2);
            root1.right = newNode(3);
            root1.left.left = newNode(4);
            root1.left.right = newNode(4);

            Node root2 = newNode(1);
            root2.left = newNode(2);
            root2.right = newNode(3);
            root2.left.left = newNode(4);
            root2.left.right = newNode(5);

            if (areIdentical(root1, root2) == true)
                Console.WriteLine("Yes ");
            else
                Console.WriteLine("No ");
        }
    }
}
