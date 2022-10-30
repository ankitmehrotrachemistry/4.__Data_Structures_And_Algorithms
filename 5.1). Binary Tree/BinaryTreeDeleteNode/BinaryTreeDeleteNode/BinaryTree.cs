using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDeleteNode
{
    public class BinaryTreeNode
    {
        public char id { get; set; }
        public BinaryTreeNode left;
        public BinaryTreeNode right;
        public BinaryTreeNode()
        {
            left = right = null;
        }
        public BinaryTreeNode(char _id)
        {
            id = _id;
            left = right = null;
        }
    }

    public class BinaryTree
    {
        private BinaryTreeNode root;
        public BinaryTree()
        {
            root = null;
        }
        public void insert(char c)
        {
            addNode(c, ref root);
        }
        private void addNode(char c, ref BinaryTreeNode rptr)
        {
            if (rptr == null)
                rptr = new BinaryTreeNode(c);
            else if (rptr.left == null)
                addNode(c, ref rptr.left);
            else if (rptr.right == null)
                addNode(c, ref rptr.right);
            else
                addNode(c, ref rptr.left);
        }
        public void inOrderTraversal()
        {
            inOrderTraversalHelper(root);
        }
        private void inOrderTraversalHelper(BinaryTreeNode r)
        {
            if (r != null)
            {
                inOrderTraversalHelper(r.left);
                Console.Write("{0}   ", r.id);
                inOrderTraversalHelper(r.right);
            }
        }
        public void preOrderTraversal()
        {
            preOrderTraversalHelper(root);
        }
        private void preOrderTraversalHelper(BinaryTreeNode r)
        {
            if (r != null)
            {
                Console.Write("{0}   ", r.id);
                preOrderTraversalHelper(r.left);
                preOrderTraversalHelper(r.right);
            }
        }
        public void postOrderTraversal()
        {
            postOrderTraversalHelper(root);
        }
        private void postOrderTraversalHelper(BinaryTreeNode r)
        {
            if (r != null)
            {
                postOrderTraversalHelper(r.left);
                postOrderTraversalHelper(r.right);
                Console.Write("{0}   ", r.id);
            }
        }
        public void removeNode(char c)
        {
            deleteNode(c, ref root);
        }

        private void deleteNode(char c, ref BinaryTreeNode root)
        {
            if (root == null)
            { }
            else
            {
                if (root.id != c)
                    deleteNode(c, ref root.left);
                // unfinished, not sure how?
            }

        }
    }
}
