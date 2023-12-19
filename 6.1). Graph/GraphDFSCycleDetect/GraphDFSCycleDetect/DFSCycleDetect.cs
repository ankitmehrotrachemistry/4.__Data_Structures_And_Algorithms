using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDFSCycleDetect
{
    class DFSCycleDetect
    {
        private readonly int V;
        private readonly List<List<int>> adj;

        public DFSCycleDetect(int V)
        {
            this.V = V;
            adj = new List<List<int>>(V);

            for (int i = 0; i < V; i++)
                adj.Add(new List<int>());
        }
        
        private bool isCyclicUtil(int i, bool[] visited,
                                        bool[] recStack)
        {
            if (recStack[i])
                return true;

            if (visited[i])
                return false;

            visited[i] = true;

            recStack[i] = true;
            List<int> children = adj[i];

            foreach (int c in children)
                if (isCyclicUtil(c, visited, recStack))
                    return true;

            recStack[i] = false;

            return false;
        }

        private void addEdge(int sou, int dest)
        {
            adj[sou].Add(dest);
        }
 
        private bool isCyclic()
        { 
            bool[] visited = new bool[V];
            bool[] recStack = new bool[V];
            
            for (int i = 0; i < V; i++)
                if (isCyclicUtil(i, visited, recStack))
                    return true;

            return false;
        }

        static void Main(string[] args)
        {
            DFSCycleDetect graph = new DFSCycleDetect(4);
            graph.addEdge(0, 1);
            graph.addEdge(0, 2);
            graph.addEdge(1, 2);
            graph.addEdge(2, 0);
            graph.addEdge(2, 3);
            graph.addEdge(3, 3);

            if (graph.isCyclic())
                Console.WriteLine("Graph contains cycle");
            else
                Console.WriteLine("Graph doesn't "
                                        + "contain cycle");
        }
    }
}
