using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinerySearchTree : IBinerySearchTree
    {
        public Node Root { get; set; }

        public BinerySearchTree()
        { }

        public BinerySearchTree(int rootKey)
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
                if (node.Key < root.Key)    //According to BST Property
                    root = root.Left;
                else
                    root = root.Right;
            }

            node.Parent = temp;

            if (temp == null)               //Again According to BST Property
                Root = node;
            else if (node.Key < temp.Key)
                temp.Left = node;
            else
                temp.Right = node;
        }

        public void InOrderTreeWalk(Node node)
        {
            if (node != null)
            {
                InOrderTreeWalk(node.Left);     //Recursive
                Console.WriteLine(node.Key);   //Print
                InOrderTreeWalk(node.Right);    //Recursive
            }
        }

        public Node TreeSearch(Node node, int key)
        {
            if (node == null || node.Key == key)
                return node;
            else if (node.Key < key)
                return TreeSearch(node.Right, key);
            else
                return TreeSearch(node.Left, key);
        }

        public Node MinimumTree(Node node)
        {
            if (node.Left != null)
                return MinimumTree(node.Left);        //Minimum will be leftmost child
            return node;
        }

        public Node MaximumTree(Node node)
        {
            if (node.Right != null)
                return MaximumTree(node.Right);     //Maximum will be rightmost child
            return node;
        }

        private void Transplant(Node u, Node v)
        {
            if (u.Parent == null)   //If u is root itself
                Root = v;
            else if (u == u.Parent.Left)    //If u is left child of it's parent
                u.Parent.Left = v;          //Making v as left child of u's parent(replacing u)
            else
                u.Parent.Right = v;

            if (v != null)
                v.Parent = u.Parent;
        }

        public void TreeDelete(int key)
        {
            Node nodeToDelete = TreeSearch(Root, key);          //Searching which node to be deleted
            if (nodeToDelete.Left == null)                      //If Left child is null
                Transplant(nodeToDelete, nodeToDelete.Right);   //Then transplant its right child on it's position
            else if (nodeToDelete.Right == null)
                Transplant(nodeToDelete, nodeToDelete.Left);
            else                                                //If both children are available
            {
                Node min = MinimumTree(nodeToDelete.Right);     //Find minimum node in right subtree(successor)

                if (min.Parent != nodeToDelete)                 //if minimum is not a child of node we want to delete
                {
                    Transplant(min, min.Right);                 //Making min's right at min's place
                    min.Right = nodeToDelete.Right;
                    min.Right.Parent = min;
                }

                Transplant(nodeToDelete, min);          // If minimum is a child of node we want to delete then it will directly transplant
                min.Left = nodeToDelete.Left;           //Making min's left is node's left which we want to delete
                min.Left.Parent = min;
            }
        }
    }
}
