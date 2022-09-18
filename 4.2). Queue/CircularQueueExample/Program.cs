using System;

namespace CircularQueueExample
{
    class Queue
    {
        public int front = -1;
        public int rear = -1;
        public int[] _arr = new int[5];
        public int Max = 5;
        public void Enqueue(int Element)
        {
            if ((front == 0 && rear == Max - 1) || (front == rear + 1))
            {
                Console.Write("Queue is Full n");
            }
            else
            {
                if (front == -1)
                {
                    front = 0;
                }
                if (rear == Max - 1)
                {
                    rear = 0;
                }
                else
                {
                    rear = rear + 1;
                }

                _arr[rear] = Element;
            }
        }
        public int dequeue()
        {
            int element = 0;
            if (front == -1)
            {
                Console.Write("Queue is empty");
            }
            element = _arr[front];
            if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else if (front == Max -1)
            {
                front = 0;
            }
            else
                front = front + 1;
            return element;
        }
        public void Display()
        {
            if (front == -1)
            {
                Console.Write("Queue is empty n");
            }
            else
            {
                int i = front;
                if (front <= rear)
                {
                    while (i <= rear)
                    {
                        Console.Write(_arr[i] + " ");
                        i++;
                    }
                }
                else
                {
                    while (i <= Max - 1)
                    {
                        Console.Write(_arr[i] + " ");
                        i++;
                    }
                    i = 0;
                    while (i <= rear)
                    {
                        Console.Write(_arr[i] + " ");
                        i++;
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            while (true)
            {
                Console.Write("n Enter the choise:");
                Console.Write("n 1  Insertion");
                Console.Write("n 2  deletion");
                Console.Write("n 3  Display");
                Console.Write("n 4  Exit");
                Console.Write("n");
                int value = Convert.ToInt16(Console.ReadLine());
                switch (value)
                {
                    case 1:
                        Console.WriteLine("Enter the value to insert:");
                        que.Enqueue(Convert.ToInt16(Console.ReadLine()));
                        break;
                    case 2:
                        int num = que.dequeue();
                        Console.WriteLine(num);
                        break;
                    case 3:
                        que.Display();
                        break;
                    case 4:
                        break;
                }
            }
        }
    }

}
