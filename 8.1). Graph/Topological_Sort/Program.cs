using System;
using System.Collections.Generic;

namespace Topological_Sort
{
    class Program
    {
		public class Node
		{
			public string val;
			public int start;
			public int end;
			public bool visited = false;
			public List<Node> neighbors;
			public Node(string val)
			{
				this.val = val;
			}
		}

		public static void Main()
		{
			var a = new Node("a");
			var z = new Node("z");
			var s = new Node("s");
			var x = new Node("x");
			var d = new Node("d");
			var c = new Node("c");
			var f = new Node("f");
			var v = new Node("v");

			var nodes = new List<Node>();
			nodes.Add(a);
			nodes.Add(z);
			nodes.Add(s);
			nodes.Add(x);
			nodes.Add(d);
			nodes.Add(c);
			nodes.Add(f);
			nodes.Add(v);

			a.neighbors = new List<Node> { s, z };
			z.neighbors = new List<Node> { a };
			s.neighbors = new List<Node> { x, a };
			x.neighbors = new List<Node> { d, c };
			d.neighbors = new List<Node> { x, f };
			c.neighbors = new List<Node> { f, v };
			f.neighbors = new List<Node> { d, c, v };
			v.neighbors = new List<Node> { f, c };
			var depList = new LinkedList<Node>();
			Dfs(nodes, depList);
			foreach (var node in depList)
			{
				Console.Write(node.val + "->");
			}
		}
		public static void Dfs(List<Node> nodes, LinkedList<Node> depList)
		{
			foreach (var node in nodes)
			{
				if (!node.visited)
				{
					DfsVisit(node, depList);
				}
			}
		}
		public static void DfsVisit(Node u, LinkedList<Node> depList)
		{
			u.start = getUnixTimeStamp();
			u.visited = true;
			foreach (var neighbor in u.neighbors)
			{
				if (!neighbor.visited)
				{
					DfsVisit(neighbor, depList);
				}
			}
			u.end = getUnixTimeStamp();
			depList.AddFirst(u);
		}
		public static int getUnixTimeStamp()
		{
			return (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
		}
	}
}