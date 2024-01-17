using System;

namespace SortKElements_Array
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
        public int Size()
        {
            return size;
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
    }
    class Program
    {
        public static void SortK(int[] arr, int size, int k)
        {
            Heap<int> hp = new Heap<int>();
            int i = 0;
            for (i = 0; i < k; i++)
            {
                hp.Enqueue(arr[i]);
            }

            int index = 0;
            for (i = k; i < size; i++)
            {
                arr[index++] = hp.Dequeue();
                hp.Enqueue(arr[i]);
            }

            while (hp.Size() > 0)
            {
                arr[index++] = hp.Dequeue();
            }
        }
        static void Main(string[] args)
        {
            int k = 3;
            int[] arr = new int[] { 1, 5, 4, 10, 50, 9 };
            int size = arr.Length;

            SortK(arr, size, k);

            Console.Write("Sort K Elements in Array is : ");

            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Sort K Elements in Array is : 1 4 5 9 10 50
*/
