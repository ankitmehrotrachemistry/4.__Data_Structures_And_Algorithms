using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapBinaryMaxDeletion
{
    public class Node
    {
        public Node left;
        public Node right;
        public int key;
        public Node(int value)
        {
            key = value;
            left = null;
            right = null;
        }
    }
    class Program
    {
        public int size;
        public Node root;

        public Program()
        {
            root = null;
            size = 0;
        }

        public int tree_height()
        {
            int i = 1;
            int sum = 0;
            while (this.size > sum + (1 << i))
            {
                sum += (1 << i);
                i++;
            }
            return i;
        }

        public void swap_node(Node first, Node second)
        {
            int temp = first.key;
            first.key = second.key;
            second.key = temp;
        }

        public void arrange_node(Node head)
        {
            if (head.left != null &&
              head.left.key > head.key)
            {
                swap_node(head, head.left);
            }
            if (head.right != null &&
              head.right.key > head.key)
            {
                swap_node(head, head.right);
            }
        }

        public Boolean add_node(Node head, int height, int level, int value)
        {
            if (level >= height)
            {
                return false;
            }
            if (head != null)
            {
                if (level - 1 == height &&
                  head.left == null ||
                  head.right == null)
                {
                    if (head.left == null)
                    {
                        head.left = new Node(value);
                    }
                    else
                    {
                        head.right = new Node(value);
                    }
                    arrange_node(head);
                    return true;
                }
                if (add_node(head.left, height, level + 1, value) ||
                  add_node(head.right, height, level + 1, value))
                {
                    arrange_node(head);
                    return true;
                }
            }
            return false;
        }
        public void insert(int value)
        {
            if (root == null)
            {
                root = new Node(value);
            }
            else
            if (root.left == null)
            {
                root.left = new Node(value);
                arrange_node(root);
            }
            else
            if (root.right == null)
            {
                root.right = new Node(value);
                arrange_node(root);
            }
            else
            {
                int height = tree_height();
                add_node(root, height, 0, value);
            }
            this.size++;
        }
        public void preorder(Node head)
        {
            if (head != null)
            {
                Console.Write(" " + head.key);
                preorder(head.left);
                preorder(head.right);
            }
        }
        public Node node_parent(Node head, int value)
        {
            if (head != null)
            {
                if (head.left != null &&
                  head.left.key == value ||
                  head.right != null &&
                  head.right.key == value)
                {
                    return head;
                }
                Node element = node_parent(head.left, value);
                if (element == null)
                {
                    element = node_parent(head.right, value);
                }
                return element;
            }
            return head;
        }
        public Node tree_last_node(Node head, int height, int level)
        {
            if (head != null)
            {
                if (level == height - 1 &&
                  (head.left != null ||
                    head.right != null))
                {
                    return head;
                }
                Node element = tree_last_node(head.right, height, level + 1);
                if (element == null)
                {
                    element = tree_last_node(head.left, height, level + 1);
                }
                return element;
            }
            return head;
        }

        public Boolean is_max_heap(Node head)
        {
            if ((head.left != null &&
                head.left.key > head.key) ||
              (head.right != null &&
                head.right.key > head.key))
            {
                return false;
            }
            return true;
        }

        public void updateDeletion(Node find_node)
        {
            //Find the new changes to make new max heap
            //O(long h)
            while (find_node != null)
            {
                //Check max heap properties

                if (is_max_heap(find_node) == false)
                {
                    //fail max heap

                    if (find_node.left != null &&
                      find_node.right != null)
                    {
                        //Repace data with maximum value

                        if (find_node.left.key > find_node.right.key)
                        {
                            swap_node(find_node, find_node.left);
                            find_node = find_node.left;
                        }
                        else
                        {
                            swap_node(find_node, find_node.right);
                            find_node = find_node.right;
                        }
                    }
                    else
                    if (find_node.right != null)
                    {
                        swap_node(find_node, find_node.right);
                        find_node = find_node.right;
                    }
                    else
                    {
                        swap_node(find_node, find_node.left);
                        find_node = find_node.left;
                    }
                }
                else
                {
                    break; ;
                }
            }
        }
        public void delete_node(int value)
        {
            if (root != null)
            {
                Node find_node = null;
                Node last_root = null;
                if (root.key == value)
                {
                    if (root.left == null &&
                      root.right == null)
                    {
                        //Delete root node
                        root = null;
                    }
                    else
                    if (root.key == value &&
                      root.right == null)
                    {
                        //Only two node in max heap
                        find_node = root;
                        root = root.left;
                        find_node = null;
                    }
                    else
                    {
                        //Find the max height by using tree node size
                        int height = tree_height();
                        if ((1 << height) - 1 == this.size)
                        {
                            //in case given height is a perfect of all leaf
                            height--;
                        }
                        //Find parent of a last node of tree
                        last_root = tree_last_node(root, height, 0);
                        if (last_root != null)
                        {
                            //updtae key value

                            if (last_root.right != null)
                            {
                                root.key = last_root.right.key;
                                //remove last node
                                last_root.right = null;
                            }
                            else
                            {
                                root.key = last_root.left.key;
                                //remove last node
                                last_root.left = null;
                            }
                            updateDeletion(root);
                        }
                    }
                    Console.Write("\nDelete Node key : " + value + "\n");
                    preorder(root);
                    //modify tree node size
                    this.size--;
                }
                else
                {
                    //When root node is not a part of delete node
                    //Find parent of a delete node key
                    find_node = node_parent(root, value);
                    if (find_node == null)
                    {
                        Console.Write("\nDelete key " + value + " not exist ");
                    }
                    else
                    {
                        //Find the max height by using tree node size
                        int height = tree_height();
                        if ((1 << height) - 1 == this.size)
                        {
                            //In case given height is a same of all leaf
                            height--;
                        }
                        //Find parent of a last node of tree
                        last_root = tree_last_node(root, height, 0);
                        if (last_root != null)
                        {
                            if (last_root == find_node)
                            {
                                //When delete last node

                                if (last_root.right != null &&
                                  last_root.right.key == value)
                                {
                                    last_root.right = null;
                                }
                                else
                                if (last_root.left != null &&
                                  last_root.left.key == value)
                                {
                                    if (last_root.right != null)
                                    {
                                        swap_node(last_root.right, last_root.left);
                                        last_root.right = null;
                                    }
                                    else
                                    {
                                        last_root.left = null;
                                    }
                                }
                            }
                            else
                            {
                                //Get actual delete node location 

                                if (find_node.right != null &&
                                  find_node.right.key == value)
                                {
                                    find_node = find_node.right;
                                }
                                else
                                {
                                    find_node = find_node.left;
                                }
                                //Updtae key value

                                if (last_root.right != null)
                                {
                                    find_node.key = last_root.right.key;
                                    //remove last node
                                    last_root.right = null;
                                }
                                else
                                {
                                    find_node.key = last_root.left.key;
                                    //remove last node
                                    last_root.left = null;
                                }
                            }
                            updateDeletion(find_node);
                            Console.Write("\nDelete Node key : " + value + "\n");
                            preorder(root);
                            //modify tree node size
                            this.size--;
                        }
                    }
                }
            }
            else
            {
                Console.Write("Empty max heap\n");
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            p.insert(5);
            p.insert(7);
            p.insert(4);
            p.insert(3);
            p.insert(9);
            p.insert(14);
            p.insert(2);
            p.insert(1);
            p.insert(6);
            p.insert(11);

            p.preorder(p.root);

            p.delete_node(1);
            p.delete_node(2);
            p.delete_node(4);
            p.delete_node(14);
            p.delete_node(15);
        }
    }
}
