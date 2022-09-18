using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    class MyJaggedArray
    {

        int[][] x = new int[2][];

        void set()
        {
            x[0] = new int[2];
            x[1] = new int[2];

            x[0][0] = 1;
            x[0][1] = 2;
        }

        void show()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(x[i][j]);
                }
            }
        }

        static void Main(string[] args)
        {
            MyJaggedArray j = new MyJaggedArray();
            j.set();
            j.show();
        }
    }
}
