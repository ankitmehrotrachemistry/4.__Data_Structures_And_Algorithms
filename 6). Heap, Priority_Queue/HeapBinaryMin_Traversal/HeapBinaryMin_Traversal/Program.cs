using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapBinaryMin_Traversal
{
    class Program
    {
        public void Preorder(int[] node, int size, int root)
        {
            if (root < size)
            {
                Console.Write(" " +node[root]);

                Preorder(node, size, 2*root+1);
                Preorder(node, size, 2*root+2);
            }
        }
        public void Inorder(int[] node, int size, int root)
        {
            if (root < size)
            {
                Inorder(node, size, 2*root+1);

                Console.Write(" " +node[root]);

                Inorder(node, size, 2*root+2);
            }
        }
        public void Postorder(int[] node, int size, int root)
        {
            if (root < size)
            {
                Postorder(node, size, 2*root+1);
                Postorder(node, size, 2*root+2);

                Console.Write(" " +node[root]);
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            int[] arr = { 1, 5, 6, 9, 7, 8, 10, 13, 12, 11 };

            int size = arr.Length;

            Console.Write("Preorder \n");
            p.Preorder(arr, size, 0);

            Console.Write("\n Inorder \n");
            p.Inorder(arr, size, 0);

            Console.Write("\n Postorder \n");
            p.Postorder(arr, size, 0);
        }
    }
}
