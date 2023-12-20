using System;

namespace MatrixKnightMoves
{
    class KnightMoves
    {
        static int M = 4;
        static int N = 4;

        static int findPossibleMoves(int[,] matrix, int currentXPos, int currentYPos)
        {
            int[] X = { 2, 1, -1, -2, -2, -1,  1,  2 };
            int[] Y = { 1, 2,  2,  1, -1, -2, -2, -1 };

            int count = 0;

            for(int i = 0; i < 8; i++)
            {
                int x = currentXPos + X[i];
                int y = currentYPos + Y[i];

                if (x >= 0 && y >= 0 && x < M && y < N && matrix[x, y] == 0)
                    count++;
            }

            return count;
        }
        static void Main(string[] args)
        {
            int[,] mat = { 
                            { 1, 0, 1, 0 },
                            { 0, 1, 1, 1 },
                            { 1, 1, 0, 1 },
                            { 0, 1, 1, 1 }
                        };

            int currentXPos = 2, currentYPos = 2;

            Console.Write("The number of possible moves by Knight at given position ({0},{1}) is : ", currentXPos , currentYPos);
            Console.WriteLine(findPossibleMoves(mat, currentXPos, currentYPos));

            Console.ReadKey();
        }
    }
}

/*
OUTPUT
The number of possible moves by Knight at given position (2,2) is : 4
*/
