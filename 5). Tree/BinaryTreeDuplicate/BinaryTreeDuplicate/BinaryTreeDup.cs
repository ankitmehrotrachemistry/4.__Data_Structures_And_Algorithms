using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDuplicate
{
    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int data)
        {
            this.data = data;
        }
    }

    class BinaryTreeDup
    {
        public static Boolean checkDuplicate(Node root, HashSet<int> s)
        {
            if (root == null)
            {
                return false;
            }

            if (s.Contains(root.data))
                return true;

            s.Add(root.data);

            return checkDuplicate(root.left, s) || checkDuplicate(root.right, s);
        }

        public static Boolean checkDup(Node root)
        {
            HashSet<int> s = new HashSet<int>();
            return checkDuplicate(root,s);
        }

        static void Main(string[] args)
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(2);
            root.left.left = new Node(3);
            if (checkDup(root))
                Console.Write("Yes");
            else
                Console.Write("No");
        }
    }
}
