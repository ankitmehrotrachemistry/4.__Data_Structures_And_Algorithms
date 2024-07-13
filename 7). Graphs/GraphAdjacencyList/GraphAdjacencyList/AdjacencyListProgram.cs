using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAdjacencyList
{
    class AdjacencyListProgram
    {
        static void addEdge(LinkedList<int>[] adj, int u, int v)
        {
            adj[u].AddLast(v);
            adj[v].AddLast(u);
        }

        static void printGraph(LinkedList<int>[] adj)
        {
            for (int i = 0; i < adj.Length; i++)
            {
                Console.WriteLine("\nAdjacency list of vertex " + i);
                Console.Write("head");

                foreach (var item in adj[i])
                {
                    Console.Write(" -> " + item);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int V = 5;
            LinkedList<int>[] adj = new LinkedList<int>[V];

            for (int i = 0; i < V; i++)
                adj[i] = new LinkedList<int>();
            
            addEdge(adj, 0, 1);
            addEdge(adj, 0, 4);
            addEdge(adj, 1, 2);
            addEdge(adj, 1, 3);
            addEdge(adj, 1, 4);
            addEdge(adj, 2, 3);
            addEdge(adj, 3, 4);

            printGraph(adj);

            Console.ReadKey();
        }
    }
}
