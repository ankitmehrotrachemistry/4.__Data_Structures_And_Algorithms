using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapMinMaximumElement
{
    class Program
    {
        public void print_data(int[] heap, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(" " +heap[i]);
            }
            Console.Write("\n");
        }
        public int find_max(int[] heap, int ans, int root, int size)
        {
            if ((heap[root * 2 + 1]) > ans)
            {
                return heap[root * 2 + 1];
            }
            else
                if ((heap[root * 2 + 2]) > ans)
            {
                return heap[root * 2 + 2];
            }
            return ans;
        }
        public void max_element(int[] heap, int size)
        {
            int max_node = heap[(size/2)];

            for (int i = (size / 2) - 1; i >= 0; i--)
            {
                max_node = find_max(heap, max_node, i, size);
            }
            Console.Write("Maximum is : " +max_node + "\n");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();

            int[] min_heap = {1,2,3,6,9,4,8,10,7};

            int size = min_heap.Length;

            obj.print_data(min_heap, size);
            obj.max_element(min_heap, size);
        }
    }
}