using System;

namespace Heap_Operation_Enqueue_Dequeue
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

            for(int i = (size/2); i>= 0; i--)
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

            if(parent >= 0 && Compare(arr, parent, child))
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
        public void Enqueue(T value)
        {
            if(size == arr.Length)
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
            if(size == 0)
            {
                throw new System.InvalidOperationException();
            }

            T value = arr[0];
            arr[0] = arr[size - 1];
            size--;

            PercolateDown(0);
            return value;
        }
        public void Print()
        {
            for(int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Heap<int> heap = new Heap<int>(true);

            heap.Enqueue(5);
            heap.Enqueue(1);
            heap.Enqueue(2);
            heap.Enqueue(4);
            heap.Enqueue(8);
            heap.Enqueue(10);
            
            Console.Write("Heap after Enqueue Operation is : ");
            heap.Print();

            Console.Write("Heap after Dequeue Operation is : ");
            while (!heap.isEmpty())
                Console.Write(heap.Dequeue() + " ");

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Heap after Enqueue Operation is : 1 4 2 5 8 10
Heap after Dequeue Operation is : 1 2 4 5 8 10
*/
