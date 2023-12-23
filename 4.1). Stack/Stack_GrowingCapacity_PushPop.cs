using System;

namespace Stack_GrowingCapacity_PushPop
{
    class Program
    {
        public class Stack
        {
            private int[] data;
            private int top = -1;
            private int minCapacity;
            private int capacity;
            public Stack() : this(1000)
            {

            }
            public Stack(int size)
            {
                data = new int[size];
                capacity = minCapacity = size;
            }
            public int size()
            {
                return (top + 1);
            }
            public bool IsEmpty()
            {
                return (top == -1);
            }
            public void Print()
            {
                for (int i = top; i > -1; i--)
                {
                    Console.Write(data[i] + " ");
                }
            }
            public void Push(int value)
            {
                if(size() == capacity)
                {
                    Console.WriteLine("Size Doubled");
                    int[] newData = new int[capacity * 2];
                    Array.Copy(data, 0, newData, 0, capacity);
                    data = newData;
                    capacity = capacity * 2;
                }
                top++;
                data[top] = value;
            }

            public int Pop()
            {
                if(IsEmpty())
                {
                    throw new System.InvalidOperationException("Stack Empty");
                }

                int topVal = data[top];
                top--;

                if(size() == capacity / 2 && capacity > minCapacity)
                {
                    Console.WriteLine("Size Halfed");
                    capacity = capacity / 2;
                    int[] newData = new int[capacity];
                    Array.Copy(data, 0, newData, 0, capacity);
                    data = newData;
                }
                return topVal;
            }
        }
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            Console.Write("Stack after Push Operation is : ");
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Print();
            Console.WriteLine();

            Console.Write("Stack after Pop Operation is : ");
            stack.Pop();
            stack.Print();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Stack after Push Operation is : 4 3 2 1
Stack after Pop Operation is : 3 2 1
*/
