using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace knapsack2
{
    public class KnapsackProgram2
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            Action<object> write = Console.Write;
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            write("Running ..\n\n");
            var rand = new Random();

            const int maxWeight = 10;
            const int N = 100000;
            var items = new List<Item>();

            for (var i = 0; i < N; i++)
            {
                items.Add(new Item { w = rand.Next(1, 10), v = rand.Next(1, 10000) });
            }

            Knapsack.Init(items, maxWeight);
            Knapsack.Run();

            stopwatch.Stop();

            write("Done\n\n");

            Knapsack.Print(write, false);


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
            M = new int[n + 1][];
            P = new int[n + 1][];
            for (var i = 0; i < M.Length; i++) { M[i] = new int[W + 1]; }
            for (var i = 0; i < P.Length; i++) { P[i] = new int[W + 1]; }
        }

        public static void Run()
        {
            var n = I.Length;

            for (var i = 1; i <= n; i++)
            {
                for (var j = 0; j <= W; j++)
                {
                    if (I[i - 1].w <= j)
                    {
                        M[i][j] = Max(M[i - 1][j], I[i - 1].v + M[i - 1][j - I[i - 1].w]);
                        if (I[i - 1].v + M[i - 1][j - I[i - 1].w] > M[i - 1][j])
                        {
                            P[i][j] = 1;
                        }
                        else
                        {
                            P[i][j] = -1;
                        }
                    }
                    else
                    {
                        P[i][j] = -1;
                        M[i][j] = M[i - 1][j];
                    }
                }
            }
            MaxValue = M[n][W];
        }

        public static void Print(Action<object> write, bool all)
        {
            var list = new List<Item>();
            list.AddRange(I);
            var w = W;
            var i = list.Count;

            write(string.Format("Items: = {0}\n", list.Count));
            if (all) { list.ForEach(a => write(string.Format("{0}\n", a))); }

            write(string.Format("\nMax weight = {0}\n", W));
            write(string.Format("Max value = {0}\n", MaxValue));
            write("\nPicks were:\n");

            var valueSum = 0;
            var weightSum = 0;
            while (i >= 0 && w >= 0)
            {
                if (P[i][w] == 1)
                {
                    valueSum += list[i - 1].v;
                    weightSum += list[i - 1].w;
                    if (all) { write(string.Format("{0}\n", list[i - 1])); }

                    w -= list[i - 1].w;
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
