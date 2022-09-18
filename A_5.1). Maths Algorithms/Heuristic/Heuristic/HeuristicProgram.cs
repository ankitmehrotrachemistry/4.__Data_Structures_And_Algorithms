using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heuristic
{
    class HeuristicProgram
    {
        private static List<List<int>> graph = new List<List<int>>();
        private static bool[] vis = new bool[100011];
        private static int i; //variables for loop iteration
        private static int j;

        private static List<int> solve_vertex(int n, int e)
        {
            //we start visiting edges
            List<int> S = new List<int>();
            for (i = 0; i < n; i++)
            {
                if (!vis[i])
                {
                    for (j = 0; j < (int)graph[i].Count; j++)
                    {
                        if (!vis[graph[i][j]]) //we only select those edges whose
                        {
                            //both vertices have not been visited yet!
                            vis[i] = true;
                            vis[graph[i][j]] = true;
                            break;
                        }
                    }
                }
            }
            for (i = 0; i < n; i++)
            {
                if (vis[i])
                {
                    S.Add(i);
                }
            }
            return S;
        }
        static void Main(string[] args)
        {
            int n;
            int e;
            int x;
            int y;
            Console.Write("Enter number of vertices:");
            //n = int.Parse(ConsoleInput.ReadToWhiteSpace(true));

            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of Edges:");
            //e = int.Parse(ConsoleInput.ReadToWhiteSpace(true));

            e = Convert.ToInt32(Console.ReadLine());

           // graph.Resize(n);
            
          //  memset(vis, 0, sizeof(bool));
            for (i = 0; i < e; i++)
            {
                Console.Write("Enter the end-points of edge ");
                Console.Write(i + 1);
                Console.Write(" : ");

                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());

                // x = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
                // y = int.Parse(ConsoleInput.ReadToWhiteSpace(true));

                x--;
                y--;
                graph[x].Add(y);
                graph[y].Add(x);
            }
            List<int> S = solve_vertex(n, e);
            Console.Write("The required vertex cover is as follows:\n");
            for (i = 0; i < (int)S.Count; i++)
            {
                Console.Write(S[i] + 1);
                Console.Write(" ");
            }
        }
    }
}
