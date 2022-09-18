// C# Program to find if two sets are disjoint using HashSet.

// Two Sets are disjoint if they don't have any elements in common.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisjointSet
{
    class Program
    {
        public static bool AreSetsDisjoint(int[] Set1, int[] Set2)
        {
            HashSet<int> Set = new HashSet<int>();

            for (int i = 0; i < Set1.Length; i++)
            {
                Set.Add(Set1[i]);
            }

            for (int i = 0; i < Set2.Length; i++)
            {
                if (Set.Contains(Set2[i]))
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int[] Set1 = new int[] {1,2,3,4,5,6,7};
            int[] Set2 = new int[] {1,8,9};
            int[] Set3 = new int[] {11,12 };

            if (AreSetsDisjoint(Set1, Set2))
            {
                Console.WriteLine("Set1 and Set2 are Disjoint !!\n");
            }
            else
            {
                Console.WriteLine("Set1 and Set2 are not Disjoint !!\n");
            }

            if (AreSetsDisjoint(Set1, Set3))
            {
                Console.WriteLine("Set1 and Set3 are Disjoint !!\n");
            }
            else
            {
                Console.WriteLine("Set1 and Set3 are not Disjoint !!\n");
            }
        }
    }
}
