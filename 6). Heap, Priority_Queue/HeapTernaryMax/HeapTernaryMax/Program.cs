using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapTernaryMax
{
    class Program
    {
        public void preorder(int[] node, int size, int root)
        {
            if (root < size)
            {
                Console.Write(" " + node[root]);

                preorder(node, size, 3 * root + 1);
                preorder(node, size, 3 * root + 2);
                preorder(node, size, 3 * root + 3);
            }
        }

        public void Swap(int[] node, int first, int second)
        {
            int auxiliary = node[first];
            node[first] = node[second];
            node[second] = auxiliary;
        }

        public int Compare(int[] node, int root, int size)
        {
            int location = -1;

            for (int i = 1; i <= 3; ++i)
            {
                if (3 * root + i < size && node[3 * root + i] > node[root])
                {
                    if (location == -1)
                    {
                        location = 3 * root + i;
                    }
                    else if (node[3 * root + i] > node[location])
                    {
                        location = 3 * root + i;
                    }
                }
            }
            if (location != -1)
            {
                Swap(node, root, location);
            }
            return location;
        }
        public void Heap(int[] node, int size, int root)
        {
            int task = Compare(node, root, size);
            if (task != -1)
            {
                Heap(node, size, task);
            }
        }
        public void makeTernaryHeap(int[] node, int size)
        {
            for (int i = (size / 3); i >= 0; i--)
            {
                Heap(node, size, i);
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            int[] node = { 10, 7, 2, 9, 1, 4, 6, 3, 8, 5, 11 };

            int size = node.Length;

            p.makeTernaryHeap(node, size);

            Console.Write(" Preorder \n");
            p.preorder(node, size, 0);
        }
    }
}