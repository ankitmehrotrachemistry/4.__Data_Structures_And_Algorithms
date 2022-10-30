// C# Program for insertion operation in Binary Tree (Level Order Traversal)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionBinaryTree
{
    class InsertionBinaryTreeProgram
    {
        public class Node
        {
            public int _key;
            public Node _left, _right;

            public Node(int key)
            {
                this._key = key;
                _left = null;
                _right = null;
            }
        }

        static void InorderTraversal(Node n)
        {
            if (n == null)
                return;
            InorderTraversal(n._left);
            Console.Write(n._key + " ");
            InorderTraversal(n._right);
        }

        static void insert(Node n, int key)
        {
            Queue<Node> q = new Queue<Node>(); // For Traversal
            q.Enqueue(n);

            while (q.Count != 0)
            {
                n = q.Peek();
                q.Dequeue();

                if (n._left == null)
                {
                    n._left = new Node(key);
                    break;
                }
                else
                    q.Enqueue(n._left);
                

                if (n._right == null)
                {
                    n._right = new Node(key);
                    break;
                }
                else
                    q.Enqueue(n._right);
            }
        }

        static Node root_Node; 

        static void Main(string[] args)
        {
            root_Node = new Node(5);

            root_Node._left = new Node(2);
            root_Node._left._left = new Node(4);
            root_Node._left._right = new Node(8);

            // Left Child of Right SubTree is Not provided value

            root_Node._right = new Node(1);
            root_Node._right._right = new Node(9);

            Console.Write("Inorder Traversal before insertion:- ");
            InorderTraversal(root_Node);

            int _key = 80;
            insert(root_Node, _key);

            Console.Write("\n Inorder Traversal after Insertion:- ");
            InorderTraversal(root_Node);
        }
    }
}
