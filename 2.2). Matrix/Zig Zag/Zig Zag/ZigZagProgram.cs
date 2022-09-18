using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zig_Zag
{
    class ZigZagProgram
    {
        static int largestZigZagSumRec(int[,] mat,
                              int i, int j, int n)
        {
            if (i == n - 1)
                return mat[i, j];
            
            int zzs = 0;

            for (int k = 0; k < n; k++)
                if (k != j)
                    zzs = Math.Max(zzs, largestZigZagSumRec(mat,
                                                   i + 1, k, n));

            return zzs + mat[i, j];
        }

        static int largestZigZag(int[,] mat, int n)
        {
            int res = 0;
            for (int j = 0; j < n; j++)
                res = Math.Max(res,
                    largestZigZagSumRec(mat, 0, j, n));

            return res;
        }
        
        public static void Main()
        {
            int n = 3;
            int[,] mat = {{4, 2, 1},
                      {3, 9, 6},
                      {11, 3, 15}};
            Console.WriteLine("Largest zigzag sum: "
                               + largestZigZag(mat, n));
        }
    }
}
