using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDeleteNode
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree b = new BinaryTree();

            b.insert('A');
            b.insert('B');
            b.insert('C');
            b.insert('D');
            b.insert('E');
            b.insert('G');
            b.insert('H');
            b.insert('F');
            b.insert('J');
            b.insert('K');
            b.insert('L');

            Console.WriteLine("The Inorder Traversal:\n");
            b.inOrderTraversal();

            Console.WriteLine("\n\nThe Preorder Traversal:\n");
            b.preOrderTraversal();

            Console.WriteLine("\n\nThe Postorder Traversal:\n");
            b.postOrderTraversal();

            b.removeNode('F');

        }
    }
}