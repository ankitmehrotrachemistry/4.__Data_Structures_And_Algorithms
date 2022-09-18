using System;
using System.Collections;
using System.Collections.Generic;
namespace HuffmanCoding
{
    class Program
    {
        private String data;
        private int frequency;
        private Program left;
        private Program right;

        public Program(String element, int freq)
        {
            data = element;
            frequency = freq;
            left = null;
            right = null;
        }

        public void setRightChild(Program n)
        {
            right = n;
        }

        public void setLeftChild(Program n)
        {
            left = n;
        }

        public Program getRightChild()
        {
            return right;
        }

        public Program getLeftChild()
        {
            return left;
        }

        public String getData()
        {
            return data;
        }

        public int getFrequency()
        {
            return frequency;
        }

        public static int getLeftChildIndex(int index)
        {
            if (((2 * index) <= MinHeap.heapSize) && (index >= 1))
            {
                return 2 * index;
            }
            return -1;
        }

        public static int getRightChildIndex(int index)
        {
            if ((((2 * index) + 1) <= MinHeap.heapSize) && (index >= 1))
            {
                return (2 * index) + 1;
            }
            return -1;
        }

        public static int getParentIndex(int index)
        {
            if ((index > 1 && (index <= MinHeap.heapSize)))
            {
                return index / 2;
            }
            return -1;
        }

        public static void inorder(Program root)
        {
            if (root != null)
            {
                inorder(root.getLeftChild());
                Console.Write(" " + root.getFrequency() + " ");
                inorder(root.getRightChild());
            }
        }
    }

    class MinHeap
    {
        public static int heapSize = 0;
        public static int heapArraySize = 100;
        public static int INF = 100000;

        public static void minHeapify(Program[] A, int index)
        {
            int leftChildIndex = Program.getLeftChildIndex(index);
            int rightChildIndex = Program.getRightChildIndex(index);

            int smallest = index;

            if ((leftChildIndex <= MinHeap.heapSize) && (leftChildIndex > 0))
            {
                if (A[leftChildIndex].getFrequency() < A[smallest].getFrequency())
                {
                    smallest = leftChildIndex;
                }
            }

            if ((rightChildIndex <= MinHeap.heapSize) && (rightChildIndex > 0))
            {
                if (A[rightChildIndex].getFrequency() < A[smallest].getFrequency())
                {
                    smallest = rightChildIndex;
                }
            }

            // smallest is not the node, node is not a heap
            if (smallest != index)
            {
                Program temp;
                temp = A[index];
                A[index] = A[smallest];
                A[smallest] = temp;
                minHeapify(A, smallest);
            }
        }
    }

    class MinQueue
    {

        public static void insert(Program[] A, Program a, int key)
        {
            MinHeap.heapSize++;
            A[MinHeap.heapSize] = a;
            int index = MinHeap.heapSize;
            while ((index > 1) && (A[Program.getParentIndex(index)].getFrequency() > a.getFrequency()))
            {
                Program temp;
                temp = A[index];
                A[index] = A[Program.getParentIndex(index)];
                A[Program.getParentIndex(index)] = temp;
                index = Program.getParentIndex(index);
            }
        }

        public static Program[] buildQueue(Program[] c, int size)
        {
            Program[] a = new Program[MinHeap.heapArraySize];
            for (int i = 0; i < size; i++)
            {
                MinQueue.insert(a, c[i], c[i].getFrequency());
            }
            return a;
        }

        public static Program extractMin(Program[] A)
        {
            Program minm = A[1];
            A[1] = A[MinHeap.heapSize];
            MinHeap.heapSize--;
            MinHeap.minHeapify(A, 1);
            return minm;
        }
    }

    class Huffman
    {
        public static HuffmanCoding.Program greedyHuffmanCode(HuffmanCoding.Program[] C)
        {
            HuffmanCoding.Program[] minQueue = MinQueue.buildQueue(C, 6);

            while (MinHeap.heapSize > 1)
            {
                HuffmanCoding.Program h = MinQueue.extractMin(minQueue);
                HuffmanCoding.Program i = MinQueue.extractMin(minQueue);
                HuffmanCoding.Program z = new HuffmanCoding.Program("NONE", h.getFrequency() + i.getFrequency());
                z.setLeftChild(h);
                z.setRightChild(i);
                MinQueue.insert(minQueue, z, z.getFrequency());
            }
            return MinQueue.extractMin(minQueue);
        }

        class Program
        {
            public static HuffmanCoding.Program greedyHuffmanCode(HuffmanCoding.Program[] C)
            {
                HuffmanCoding.Program[] minQueue = MinQueue.buildQueue(C, 6);

                while (MinHeap.heapSize > 1)
                {
                    HuffmanCoding.Program h = MinQueue.extractMin(minQueue);
                    HuffmanCoding.Program i = MinQueue.extractMin(minQueue);
                    HuffmanCoding.Program z = new HuffmanCoding.Program("NONE", h.getFrequency() + i.getFrequency());
                    z.setLeftChild(h);
                    z.setRightChild(i);
                    MinQueue.insert(minQueue, z, z.getFrequency());
                }
                return MinQueue.extractMin(minQueue);
            }

            public static void main(String[] args)
            {
                HuffmanCoding.Program a = new HuffmanCoding.Program("a", 42);
                HuffmanCoding.Program b = new HuffmanCoding.Program("b", 20);
                HuffmanCoding.Program c = new HuffmanCoding.Program("c", 5);
                HuffmanCoding.Program d = new HuffmanCoding.Program("d", 10);
                HuffmanCoding.Program e = new HuffmanCoding.Program("e", 11);
                HuffmanCoding.Program f = new HuffmanCoding.Program("f", 12);

                HuffmanCoding.Program[] C = { a, b, c, d, e, f };

                HuffmanCoding.Program z = Huffman.greedyHuffmanCode(C);
                HuffmanCoding.Program.inorder(z);
                Console.Write("");
            }
        }
    }
}