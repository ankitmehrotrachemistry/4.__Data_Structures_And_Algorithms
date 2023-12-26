using System;

namespace Queue_Basics
{
    class Program
    {
        public class Queue
        {
            private int capacity;
            private int[] data;
            private int size = 0;
            private int front = 0;
            private int back = 0;

            public Queue(int n = 1000)
            {
                capacity = n;
                data = new int[n];
            }

            public bool IsEmpty()
            {
                return size == 0;
            }

            public int Size()
            { 
                return size; 
            }  
            
            public void Print()
            {
                if(size == 0)
                {
                    Console.Write("Queue is Empty");

                    return;
                }
                int temp = front;
                int s = size;
                Console.Write("Queue is : ");
                while(s > 0)
                {
                    s--;
                    Console.Write(data[temp] + " ");
                    temp = (++temp) % capacity;
                }
                Console.WriteLine();
            }

            public bool Add(int value)
            {
                if(size >= capacity)
                {
                    Console.WriteLine("Queue is full");
                    return false;
                }
                else
                {
                    size++;
                    data[back] = value;
                    back = (++back) % capacity;
                }
                return true;
            }

            public int Remove()
            {
                int value;
                if(size <= 0)
                {
                    Console.WriteLine("Queue Empty");
                    return -999;
                }
                else
                {
                    size--;
                    value = data[front];
                    front = (++front)%capacity;
                }
                return value; 
            }
        }
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Add(1);
            queue.Add(2);
            queue.Add(3);
            queue.Add(4);

            Console.WriteLine("IsEmpty : " + queue.IsEmpty());
            Console.WriteLine("Size : " + queue.Size());
            Console.WriteLine("Queue remove : " + queue.Remove());
            Console.WriteLine("Queue remove : " + queue.Remove());

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
IsEmpty : False
Size : 4
Queue remove : 1
Queue remove : 2
*/
