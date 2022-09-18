using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapMinHeapToMaxHeap
{
    class Program
    {
        public void Swap(int[] arr, int first, int second)
        {
            int auxiliary = arr[first];
            arr[first] = arr[second];
            arr[second] = auxiliary;
        }

        public int Compare(int[] arr, int left, int right, int root, int size)
        {
            int location = -1;

            if (left < size && arr[left] > arr[root])
            {
                if (right < size && arr[right] > arr[left])
                {
                    Swap(arr, right, root);
                    location = right;
                }
                else
                {
                    Swap(arr, left, root);
                    location = left;
                }
            }
            else
                if (right < size && arr[right] > arr[root])
                {
                    Swap(arr, right, root);
                    location = right;
                }
            return location;
        }

        public void heap(int[] arr, int size, int root)
        {
            int left = 2 * root + 1;
            int right = 2 * root + 2;
            int next = Compare(arr, left, right, root, size);
            if (next != -1)
            {
                heap(arr, size, next);
            }
        }
        public void print_data(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.Write("\n");
        }
        public void max_heap(int[] arr, int size)
        {
            for (int i = (size / 2) - 1; i >= 0; i--)
            {
                heap(arr, size, i);
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            /*
            1
          /    \
         5      6
        / \    / \
       9   7  8   10
      / \
     16  18 

 */
            int[] heap_data = { 1,5,6,9,7,8,10,16,18};

            int n = heap_data.Length;

            Console.WriteLine("Min Heap : \n");

            p.print_data(heap_data, n);
            p.max_heap(heap_data, n);

            Console.WriteLine("Max Heap : \n");
            p.print_data(heap_data, n);

        }
    }
}
