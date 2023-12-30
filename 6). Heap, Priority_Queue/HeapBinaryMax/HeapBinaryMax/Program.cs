using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapBinaryMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============= Max Binary Heap =============");
            MaxBinaryHeap maxHeap = new MaxBinaryHeap();
            maxHeap.Insert(18);
            maxHeap.Insert(27);
            maxHeap.Insert(12);
            maxHeap.Insert(39);
            maxHeap.Insert(33);
            maxHeap.Insert(41);

            Console.WriteLine(maxHeap.Values);

            Console.WriteLine(maxHeap.ExtractMax());
            Console.WriteLine(maxHeap.ExtractMax());
            Console.WriteLine(maxHeap.ExtractMax());
            Console.WriteLine(maxHeap.ExtractMax());
            Console.WriteLine(maxHeap.ExtractMax());
            Console.WriteLine(maxHeap.ExtractMax());
        }
    }
}
