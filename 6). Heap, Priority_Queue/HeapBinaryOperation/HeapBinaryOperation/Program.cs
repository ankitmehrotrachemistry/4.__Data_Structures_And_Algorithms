using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapBinaryOperation
{
    public class BinaryHeap
    {
        private List<int> heap = new List<int>();
        private int left(int parent)
        {
            int l = 2 * parent + 1;
            if (l < heap.Count)
            {
                return l;
            }
            else
            {
                return -1;
            }
        }
        private int right(int parent)
        {
            int r = 2 * parent + 2;
            if (r < heap.Count)
            {
                return r;
            }
            else
            {
                return -1;
            }
        }
        private int parent(int child)
        {
            int p = (child - 1) / 2;
            if (child == 0)
            {
                return -1;
            }
            else
            {
                return p;
            }
        }
        private void heapifyup(int i)
        {
            if (i >= 0 && parent(i) >= 0 && heap[parent(i)] > heap[i])
            {
                int temp = heap[i];
                heap[i] = heap[parent(i)];
                heap[parent(i)] = temp;
                heapifyup(parent(i));
            }
        }
        private void heapifydown(int i)
        {

            int child = left(i);
            int child1 = right(i);
            if (child >= 0 && child1 >= 0 && heap[child] > heap[child1])
            {
                child = child1;
            }
            if (child > 0 && heap[i] > heap[child])
            {
                int temp = heap[i];
                heap[i] = heap[child];
                heap[child] = temp;
                heapifydown(child);
            }
        }
        public BinaryHeap()
        {
        }
        public void Insert(int element)
        {
            heap.Add(element);
            heapifyup(heap.Count - 1);
        }
        public void DeleteMin()
        {
            if (heap.Count == 0)
            {
                Console.Write("Heap is Empty");
                Console.Write("\n");
                return;
            }
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            heapifydown(0);
            Console.Write("Element Deleted");
            Console.Write("\n");
        }
        public int ExtractMin()
        {
            if (heap.Count == 0)
            {
                return -1;
            }
            else
            {
                return heap[0];
            }
        }
        public void DisplayHeap()
        {
            List<int>.Enumerator pos = heap.GetEnumerator();
            Console.Write("Heap -->  ");
            while (pos.MoveNext())
            {
                Console.Write(pos.Current);
                Console.Write(" ");
            }
            Console.Write("\n");
        }
        public int Size()
        {
            return heap.Count;
        }
    }

    public static class Program
    {
        static void Main(string[] args)
        {
            BinaryHeap h = new BinaryHeap();
            while (true)
            {
                Console.Write("------------------");
                Console.Write("\n");
                Console.Write("Operations on Heap");
                Console.Write("\n");
                Console.Write("------------------");
                Console.Write("\n");
                Console.Write("1.Insert Element");
                Console.Write("\n");
                Console.Write("2.Delete Minimum Element");
                Console.Write("\n");
                Console.Write("3.Extract Minimum Element");
                Console.Write("\n");
                Console.Write("4.Print Heap");
                Console.Write("\n");
                Console.Write("5.Exit");
                Console.Write("\n");
                int choice;
                int element;
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the element to be inserted: ");
                        element = Convert.ToInt32(Console.ReadLine());
                        h.Insert(element);
                        break;
                    case 2:
                        h.DeleteMin();
                        break;
                    case 3:
                        Console.Write("Minimum Element");
                        if (h.ExtractMin() == -1)
                        {
                            Console.Write("Heap is Empty");
                        }
                        else
                        {
                            Console.Write("Minimum Element is:-" + h.ExtractMin());
                        }
                        break;
                    case 4:
                        Console.Write("Display Heap Elements:-");
                        h.DisplayHeap();
                        break;
                    


                }
            }
        }
    }
}
