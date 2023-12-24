using System;
using System.Collections.Generic;

namespace Queue_Reverse_K_Elements
{
    class Program
    {
        public static void reverseKElementQueue(Queue<int> queue, int k)
        {
            Stack<int> stack = new Stack<int>();
            int i = 0, diff, temp;

            while(queue.Count != 0 && i < k)
            {
                stack.Push(queue.Dequeue());
                i++;
            }

            while(stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            diff = queue.Count - k;

            while(diff > 0)
            {
                temp = queue.Dequeue();
                queue.Enqueue(temp);
                diff -= 1;
            }
        }
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.Write("Elements of Queue are : ");
            foreach (var elem in queue)
                Console.Write(elem + " ");

            Console.WriteLine();

            reverseKElementQueue(queue, 3);

            Console.Write("Elements after reversal of K Elements in Queue : ");

            foreach (var elem in queue)
                Console.Write(elem + " ");

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
Elements of Queue are : 1 2 3 4
Elements after reversal of K Elements in Queue : 3 2 1 4
*/
