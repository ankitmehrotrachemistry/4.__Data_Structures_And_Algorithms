using System;

namespace Heap_Product_K_Min_Elements_MinHeap
{
    class Heap<T> where T : IComparable<T>
    {
        private int size;
        private T[] arr;
        private bool isMinHeap;

        public Heap(bool isMin = true)
        {
            int CAPACITY = 32;
            arr = new T[CAPACITY];
            size = 0;
            isMinHeap = isMin;
        }
        public Heap(T[] array, bool isMin = true)
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
            Heap<int> heap = new Heap<int>(array, !inc);

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
        public static int KSmallestProduct2(int[] arr, int size, int k)
        {
            Heap<int> heap = new Heap<int>();
            
            int i = 0;
            int product = 1;
            
            for (i = 0; i < size; i++)
            {
                heap.Enqueue(arr[i]);
            }

            i = 0;
            while (i < size && i < k)
            {
                product *= heap.Dequeue();
                i += 1;
            }
            
            return product;
        }
        static void Main(string[] args)
        {
            int[] arr2 = new int[] { 8, 7, 6, 5, 7, 3, 2, 1 };
            Console.WriteLine("Kth Smallest product is : " + KSmallestProduct2(arr2, 8, 5));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Kth Smallest product is : 180
*/
