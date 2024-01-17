using System;

namespace Heap_IsMaxHeap
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
        public static bool IsMaxHeap(int[] arr, int size)
        {
            int lchild, rchild;
            // last element index size - 1
            for (int parent = 0; parent < (size / 2 + 1); parent++)
            {
                lchild = parent * 2 + 1;
                rchild = parent * 2 + 2;
                // heap property check.
                if (((lchild < size) && (arr[parent] < arr[lchild])) || ((rchild < size) && (arr[parent] < arr[rchild])))
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[] arr3 = new int[] { 8, 7, 6, 5, 7, 5, 2, 1 };
            Console.WriteLine("IsMaxHeap :: " + IsMaxHeap(arr3, arr3.Length));

            int[] arr4 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine("IsMaxHeap :: " + IsMaxHeap(arr4, arr4.Length));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
IsMaxHeap :: True
IsMaxHeap :: False
*/
