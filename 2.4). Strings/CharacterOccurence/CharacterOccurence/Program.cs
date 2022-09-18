using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterOccurence
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Engineer";
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'e')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
