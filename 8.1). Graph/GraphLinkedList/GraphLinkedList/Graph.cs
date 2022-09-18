// C# Program to represent Graph using Adjacency List

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLinkedList
{
    class Graph
    {
        static void addEdge(LinkedList<int>[] adjList, int u, int v)
        {
            adjList[u].AddLast(v);
            adjList[v].AddLast(u);
        }

        static void displayGraph(LinkedList<int>[] adjList)
        {
            for (int i = 0; i < adjList.Length; i++)
            {
                Console.WriteLine("\n Adjacency List is " +i);
                Console.Write("Head");

                foreach (var item in adjList[i])
                {
                    Console.Write("->" + item);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int V = 6;

            LinkedList<int>[] adjList = new LinkedList<int>[V];

            for (int i = 0; i < V; i++)
                adjList[i] = new LinkedList<int>();

            {
                addEdge(adjList, 0, 1);
                addEdge(adjList, 0, 2);
                addEdge(adjList, 2, 3);
                addEdge(adjList, 2, 4);
                addEdge(adjList, 3, 4);
                addEdge(adjList, 4, 5);

                displayGraph(adjList);
            }
        }
    }
}