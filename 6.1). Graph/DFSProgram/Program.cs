using System;
using System.Collections.Generic;

namespace DFSProgram
{
	public class Graph
	{
		private int V;

		private List<int>[] adj;
		Graph(int v)
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
		void DFSUtil(int v, bool[] visited)
		{
			visited[v] = true;
			Console.Write(v + " ");

			foreach (int i in adj[v])
			{
				int n = i;
				if (!visited[n])
					DFSUtil(n, visited);
			}
		}

		void DFS()
		{
			bool[] visited = new bool[V];

			for (int i = 0; i < V; ++i)
				if (visited[i] == false)
					DFSUtil(i, visited);
		}
		public static void Main(String[] args)
		{
			Graph g = new Graph(4);

			g.addEdge(0, 1);
			g.addEdge(0, 2);
			g.addEdge(1, 2);
			g.addEdge(2, 0);
			g.addEdge(2, 3);
			g.addEdge(3, 3);

			Console.WriteLine("Following is Depth First Traversal");

			g.DFS();
		}
	}

}