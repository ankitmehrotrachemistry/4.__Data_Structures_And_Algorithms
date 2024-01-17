using System;

namespace kthSmallest_Priority_Queue
{
    public class PriorityQueue<T> where T : IComparable<T>
    {
        private int size;
        private T[] arr;
        private bool isMinHeap;

        public PriorityQueue(bool isMin = true)
        {
            int CAPACITY = 32;
            arr = new T[CAPACITY];
            size = 0;
            isMinHeap = isMin;
        }
        public PriorityQueue(T[] array, bool isMin = true)
        {
            size = array.Length;
            arr = array;
            isMinHeap = isMin;

            for (int i = (size / 2); i >= 0; i--)
            {
                PercolateDown(i);
            }
        }
        private bool Compare(T[] arr, int first, int second)
        {
            if (isMinHeap)
                return arr[first].CompareTo(arr[second]) > 0;
            else
                return arr[first].CompareTo(arr[second]) < 0;
        }
        private void PercolateDown(int parent)
        {
            int leftChild = 2 * parent + 1;
            int rightChild = leftChild + 1;
            int child = -1;

            if (leftChild < size)
            {
                child = leftChild;
            }

            if (rightChild < size && Compare(arr, leftChild, rightChild))
            {
                child = rightChild;
            }

            if (child != -1 && Compare(arr, parent, child))
            {
                T temp = arr[parent];
                arr[parent] = arr[child];
                arr[child] = temp;
                PercolateDown(child);
            }
        }
        private void PercolateUp(int child)
        {
            int parent = (child - 1) / 2;

            if (parent >= 0 && Compare(arr, parent, child))
            {
                T temp = arr[child];
                arr[child] = arr[parent];
                arr[parent] = temp;
                PercolateUp(parent);
            }
        }
        public bool isEmpty()
        {
            return (size == 0);
        }
        public int Size()
        {
            return size;
        }
        public T Peek()
        {
            if (size == 0)
            {
                throw new System.InvalidOperationException();
            }
            return arr[0];
        }
        public void Enqueue(T value)
        {
            if (size == arr.Length)
            {
                DoubleSize();
            }
            arr[size++] = value;

            PercolateUp(size - 1);
        }
        private void DoubleSize()
        {
            T[] old = arr;
            arr = new T[old.Length * 2];
            Array.Copy(old, 0, arr, 0, size);
        }
        public T Dequeue()
        {
            if (size == 0)
            {
                throw new System.InvalidOperationException();
            }

            T value = arr[0];
            arr[0] = arr[size - 1];
            size--;

            PercolateDown(0);
            return value;
        }
        public static void HeapSort(int[] array, bool inc)
        {
            PriorityQueue<int> heap = new PriorityQueue<int>(array, !inc);

            for (int i = 0; i < array.Length; i++)
            {
                array[array.Length - i - 1] = heap.Dequeue();
            }
        }
        public void Print()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        public static int KthSmallest2(int[] arr, int size, int k)
        {
            PriorityQueue<int> pq = new PriorityQueue<int>();

            for(int i = 0; i < size; i++)
            {
                pq.Enqueue(arr[i]) ;
            }
            for (int i = 0; i < k-1; i++)
            {
                pq.Dequeue();
            }
            return pq.Peek();
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 8, 7, 6, 4, 7, 5, 2, 1 };

            Console.WriteLine("Kth smallest element using Priority Queue is : " + KthSmallest2(arr, arr.Length, 4));
            
            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Kth smallest element using Priority Queue is : 5
*/
