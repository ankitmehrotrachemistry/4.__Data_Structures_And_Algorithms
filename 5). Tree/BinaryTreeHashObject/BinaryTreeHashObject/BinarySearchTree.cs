using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeHashObject
{
    public class BinarySearchTree : IBinarySearchTree
    {
        public Node Root { get; set; }
        public BinarySearchTree()
        {
            
        }

        public BinarySearchTree(int rootKey)
        {
            Root = new Node() { Key = rootKey };
        }

        public void Insert(Node node)
        {
            Node temp = null;
            Node root = Root;

            while (root != null)
            {
                temp = root;

                if (node.Key < root.Key)
                    root = root.Left;
                else
                    root = root.Right;
            }

            node.Parent = temp;

            if (temp == null)
                Root = node;
            else if (node.Key < temp.Key)
                temp.Left = node;
            else
                temp.Right = node;
        }

        public void InorderTreeWalk(Node node)
        {
            if (node != null)
            {
                InorderTreeWalk(node.Left);
                Console.WriteLine(node.Key);
                InorderTreeWalk(node.Right);
            }
        }
    }
}
