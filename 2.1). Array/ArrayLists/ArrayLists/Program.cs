// Unboxing Program in C#

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists
{
    class TheArrayList
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            ArrayList array = new ArrayList();

            const int max = 1000000;
            var s1 = Stopwatch.StartNew();
            // Version 1: use List.
            for (int i = 0; i < max; i++)
            {
                list.Add(10);
                list.Add(20);
                list.Add(30);
                list.Remove(30);
                if (list[list.Count - 1] != 20)
                {
                    return;
                }
                list.Clear();
            }
            s1.Stop();
            var s2 = Stopwatch.StartNew();
            // Version 2: use ArrayList.
            for (int i = 0; i < max; i++)
            {
                array.Add(10);
                array.Add(20);
                array.Add(30);
                array.Remove(30);
                if ((int)array[array.Count - 1] != 20)
                {
                    return;
                }
                array.Clear();
            }
            s2.Stop();
            Console.WriteLine(s1.Elapsed.TotalMilliseconds);
            Console.WriteLine(s2.Elapsed.TotalMilliseconds);
            Console.Read();
        }
    }
}
