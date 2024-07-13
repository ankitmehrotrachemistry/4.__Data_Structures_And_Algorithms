using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphKnightBFSMove
{
    class KnightMove
    {
        public class cell
        {
            public int x, y;
            public int dis;

            public cell(int x, int y, int dis)
            {
                this.x = x;
                this.y = y;
                this.dis = dis;
            }
        }

        static bool isInside(int x, int y, int N)
        {
            if (x >= 1 && x <= N && y >= 1 && y <= N)
                return true;
            return false;
        }

        static int minStepToReachTarget(int[] knightPos, int[] targetPos, int N)
        {
            int[] dx = { -2, -1, 1, 2, -2, -1, 1, 2 };
            int[] dy = { -1, -2, -2, -1, 1, 2, 2, 1 };
            
            Queue<cell> q = new Queue<cell>();
            
            q.Enqueue(new cell(knightPos[0], knightPos[1], 0));

            cell t;
            int x, y;
            bool[,] visit = new bool[N + 1, N + 1];
            
            for (int i = 1; i <= N; i++)
                for (int j = 1; j <= N; j++)
                    visit[i, j] = false;
            
            visit[knightPos[0], knightPos[1]] = true;
            
            while (q.Count != 0)
            {
                t = q.Peek();
                q.Dequeue();
                
                if (t.x == targetPos[0] &&
                    t.y == targetPos[1])
                    return t.dis;
                
                for (int i = 0; i < 8; i++)
                {
                    x = t.x + dx[i];
                    y = t.y + dy[i];
                    
                    if (isInside(x, y, N) && !visit[x, y])
                    {
                        visit[x, y] = true;
                        q.Enqueue(new cell(x, y, t.dis + 1));
                    }
                }
            }
            return int.MaxValue;
        }

        static void Main(string[] args)
        {
            int N = 30;
            int[] knightPos = { 1, 1 };
            int[] targetPos = { 30, 30 };
            Console.WriteLine(minStepToReachTarget(knightPos,
                                                   targetPos, N));
        }
    }
}
