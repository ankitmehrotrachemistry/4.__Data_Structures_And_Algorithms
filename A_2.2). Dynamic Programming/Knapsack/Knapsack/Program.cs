using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace Knapsack
{
    public class KnapsackProgram
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            Action<object> write = Console.Write;
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            write("Running ..\n\n");
            var rand = new Random();

            const int N = 10;
            const int maxWeight = 20;
            var items = new List<Item>();

            for (var i = 0; i < N; i++)
            {
                items.Add(new Item { w = rand.Next(1, 10), v = rand.Next(1, 100) });
            }

            Knapsack.Init(items, maxWeight);
            Knapsack.Run();

            stopwatch.Stop();

            write("Done\n\n");

            Knapsack.PrintPicksMatrix(write);
            Knapsack.Print(write, true);

            write(string.Format("\n\nDuration: {0}\nPress a key to exit\n",
                                stopwatch.Elapsed.ToString()));
            Console.ReadKey();
        }
    }

    static class Knapsack
    {
        static int[][] M { get; set; }
        static int[][] P { get; set; }
        static Item[] I { get; set; }
        public static int MaxValue { get; private set; }
        static int W { get; set; }

        public static void Init(List<Item> items, int maxWeight)
        {
            I = items.ToArray();
            W = maxWeight;

            var n = I.Length;
            M = new int[n][];
            P = new int[n][];
            for (var i = 0; i < M.Length; i++) { M[i] = new int[W + 1]; }
            for (var i = 0; i < P.Length; i++) { P[i] = new int[W + 1]; }
        }

        public static void Run()
        {
            MaxValue = Recursive(I.Length - 1, W, 1);
        }

        static int Recursive(int i, int w, int depth)
        {
            var take = 0;
            if (M[i][w] != 0) { return M[i][w]; }

            if (i == 0)
            {
                if (I[i].w <= w)
                {
                    P[i][w] = 1;
                    M[i][w] = I[0].v;
                    return I[i].v;
                }

                P[i][w] = -1;
                M[i][w] = 0;
                return 0;
            }

            if (I[i].w <= w)
            {
                take = I[i].v + Recursive(i - 1, w - I[i].w, depth + 1);
            }

            var dontTake = Recursive(i - 1, w, depth + 1);

            M[i][w] = Max(take, dontTake);

            if (take > dontTake) { P[i][w] = 1; }
            else { P[i][w] = -1; }

            return M[i][w];
        }

        public static void Print(Action<object> write, bool full)
        {
            var list = new List<Item>();
            list.AddRange(I);
            var w = W;
            var i = list.Count - 1;

            write(string.Format("Items: = {0}\n", list.Count));
            if (full) { list.ForEach(a => write(string.Format("{0}\n", a))); }

            write(string.Format("\nMax weight = {0}\n", W));
            write(string.Format("Max value = {0}\n", MaxValue));
            write("\nPicks were:\n");

            var valueSum = 0;
            var weightSum = 0;
            while (i >= 0 && w >= 0)
            {
                if (P[i][w] == 1)
                {
                    valueSum += list[i].v;
                    weightSum += list[i].w;
                    if (full) { write(string.Format("{0}\n", list[i])); }
                    w -= list[i].w;
                }

                i--;
            }
            write(string.Format("\nvalue sum: {0}\nweight sum: {1}",
                valueSum, weightSum));
        }

        public static void PrintPicksMatrix(Action<object> write)
        {
            write("\n\n");
            foreach (var i in P)
            {
                foreach (var j in i)
                {
                    var s = j.ToString();
                    var _ = s.Length > 1 ? " " : "  ";
                    write(string.Concat(s, _));
                }
                write("\n");
            }
        }

        static int Max(int a, int b)
        {
            return a > b ? a : b;
        }
    }

    class Item
    {
        private static int _counter;
        public int Id { get; private set; }
        public int v { get; set; }
        public int w { get; set; }
        public Item()
        {
            Id = ++_counter;
        }

        public override string ToString()
        {
            return string.Format("Id: {0}  v: {1}  w: {2}",
                                 Id, v, w);
        }
    }
}
