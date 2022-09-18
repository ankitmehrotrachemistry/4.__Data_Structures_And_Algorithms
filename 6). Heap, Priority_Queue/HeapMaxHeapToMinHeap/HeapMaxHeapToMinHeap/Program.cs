using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapMaxHeapToMinHeap
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

            if (left < size && arr[left] < arr[root])
            {
                if (right < size && arr[right] < arr[left])
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
                if (right < size & arr[right] < arr[root])
                {
                    Swap(arr, right, root);
                    location = right;
                }
            return location;    
        }

        public void Heap(int[] arr, int size, int root)
        {
            int left = 2 * root + 1;
            int right = 2 * root + 2;

            int next_in = Compare(arr, left, right, root, size);

            if (next_in != -1)
            {
                Heap(arr, size, next_in);
            }
        }

        public void print_data(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(" " +arr[i]);
            }
            Console.Write("\n");
        }

        public void min_Heap(int[] arr, int size)
        {
            for (int i = (size / 2) - 1; i >= 0; i--)
            {
                Heap(arr, size, i);
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            /*
             
           10
         /    \
        9       8
       / \     / \
      5   7   1   6
     /
    4
              */

            int[] heap_data = { 10,9,8,5,7,1,6,4};

            int n = heap_data.Length;

            Console.WriteLine("Max Heap is : \n");
            p.print_data(heap_data, n);
            p.min_Heap(heap_data, n);

            Console.WriteLine("Min Heap is :\n");
            p.print_data(heap_data, n);
        }
    }
}
