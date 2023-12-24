using System;
using System.Collections.Generic;

namespace Two_Stack_Using_Array
{
    class Program
    {
        private readonly int MAX_SIZE = 50;

        internal int top1;
        internal int top2;
        internal int[] data;
        public Program()
        {
            top1 = -1;
            top2 = MAX_SIZE;
            data = new int[MAX_SIZE];
        }
        public void StackPush1(int value)
        {
            if(top1 < top2 - 1)
            {
                data[++top1] = value;
            }
            else
            {
                Console.Write("Stack is Full");
            }
        }
        public void StackPush2(int value)
        {
            if (top1 < top2 - 1)
            {
                data[--top2] = value;
            }
            else
            {
                Console.Write("Stack is Full");
            }
        }
        public int StackPop1()
        {
            if(top1 >= 0)
            {
                int value = data[top1--];
                return value;
            }
            else
            {
                Console.Write("Stack Empty !");
            }
            return -999;
        }
        public int StackPop2()
        {
            if (top2 < MAX_SIZE)
            {
                int value = data[top2++];
                return value;
            }
            else
            {
                Console.Write("Stack Empty !");
            }
            return -999;
        }
        static void Main(string[] args)
        {
            Program st = new Program();
            st.StackPush1(1);
            st.StackPush1(2);
            st.StackPush1(3);
            st.StackPush2(11);
            st.StackPush2(22);
            st.StackPush2(33);
            Console.WriteLine("stk1 pop: " + st.StackPop1());
            Console.WriteLine("stk1 pop: " + st.StackPop1());
            Console.WriteLine("stk2 pop: " + st.StackPop2());
            Console.WriteLine("stk2 pop: " + st.StackPop2());

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
stk1 pop: 3
stk1 pop: 2
stk2 pop: 33
stk2 pop: 22
*/
