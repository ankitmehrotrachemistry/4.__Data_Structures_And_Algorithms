using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapBinary
{
    public class MinHeap
    {
        private int[] harr; // pointer to array of elements in heap
        private int capacity; // maximum possible size of min heap
        private int heap_size; // Current number of elements in min heap
                               // Constructor 

        // Constructor: Builds a heap from a given array a[] of given size 
        public MinHeap(int cap)
        {
            heap_size = 0;
            capacity = cap;
            harr = new int[cap];
        }
        
        public void MinHeapify(int i)
        {
            int l = left(i);
            int r = right(i);
            int smallest = i;
            if (l < heap_size && harr[l] < harr[i])
            {
                smallest = l;
            }
            if (r < heap_size && harr[r] < harr[smallest])
            {
                smallest = r;
            }
            if (smallest != i)
            {
                GlobalMembers.swap(ref harr[i], ref harr[smallest]);
                MinHeapify(smallest);
            }
        }

        public int parent(int i)
        {
            return (i - 1) / 2;
        }
        
        public int left(int i)
        {
            return (2 * i + 1);
        }

        public int right(int i)
        {
            return (2 * i + 2);
        }
        
        public int extractMin()
        {
            if (heap_size <= 0)
            {
                //return INT_MAX;
            }
            if (heap_size == 1)
            {
                heap_size--;
                return harr[0];
            }

            // Store the minimum value, and remove it from heap
            int root = harr[0];
            harr[0] = harr[heap_size - 1];
            heap_size--;
            MinHeapify(0);

            return root;
        }
        
        public void decreaseKey(int i, int new_val)
        {
            harr[i] = new_val;
            while (i != 0 && harr[parent(i)] > harr[i])
            {
                GlobalMembers.swap(ref harr[i], ref harr[parent(i)]);
                i = parent(i);
            }
        }

        public int getMin()
        {
            return harr[0];
        }
        
        public void deleteKey(int i)
        {
            //decreaseKey(i, INT_MIN);
            extractMin();
        }
        
        public void insertKey(int k)
        {
            if (heap_size == capacity)
            {
                Console.Write("\nOverflow: Could not insertKey\n");
                return;
            }
            
            heap_size++;
            int i = heap_size - 1;
            harr[i] = k;
            
            while (i != 0 && harr[parent(i)] > harr[i])
            {
                GlobalMembers.swap(ref harr[i], ref harr[parent(i)]);
                i = parent(i);
            }
        }
    }

    public static class GlobalMembers
    {
        public static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        
        static void Main(string[] args)
        {
            MinHeap h = new MinHeap(11);
            h.insertKey(3);
            h.insertKey(2);
            h.deleteKey(1);
            h.insertKey(15);
            h.insertKey(5);
            h.insertKey(4);
            h.insertKey(45);
            Console.Write(h.extractMin());
            Console.Write(" ");
            Console.Write(h.getMin());
            Console.Write(" ");
            h.decreaseKey(2, 1);
            Console.Write(h.getMin());
        }
    }
}