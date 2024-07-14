using System;
using System.Collections;

namespace StackReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            Stack rev = new Stack();

            st.Push('A');
            st.Push('B');
            st.Push('C');
            st.Push('D');

            Console.WriteLine("Current Stack: ");

            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            while (st.Count != 0)
            {
                rev.Push(st.Pop());
            }

            Console.WriteLine("Reverse Stack: ");

            foreach (char c in rev)
            {
                Console.Write(c + " ");
            }
        }
    }
}
