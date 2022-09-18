using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCountPossiblePath
{
    class GraphPossiblePath
    {
        int V;
        
        private List<int>[] adj;

        GraphPossiblePath(int v)
        {
            V = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; ++i)
                adj[i] = new List<int>();
        }
        
        void addEdge(int v, int w)
        {
            adj[v].Add(w);
        }
        
        int countPathsUtil(int u, int d,
                           int pathCount)
        {
            if (u == d)
            {
                pathCount++;
            }
            
            else
            {
                foreach (int i in adj[u])
                {
                    int n = i;
                    pathCount = countPathsUtil(n, d,
                                               pathCount);
                }
            }
            return pathCount;
        }
        
        int countPaths(int s, int d)
        {
            int pathCount = 0;
            pathCount = countPathsUtil(s, d,
                                       pathCount);
            return pathCount;
        }

        static void Main(string[] args)
        {
            GraphPossiblePath g = new GraphPossiblePath(5);
            g.addEdge(0, 1);
            g.addEdge(0, 2);
            g.addEdge(0, 3);
            g.addEdge(1, 3);
            g.addEdge(2, 3);
            g.addEdge(1, 4);
            g.addEdge(2, 4);

            int s = 0, d = 3;
            Console.WriteLine(g.countPaths(s, d));
        }
    }
}
