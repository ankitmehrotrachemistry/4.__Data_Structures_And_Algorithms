using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapBinaryMin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============= Min Binary Heap =============");
            MinBinaryHeap minHeap = new MinBinaryHeap();
            minHeap.Insert(18);
            minHeap.Insert(27);
            minHeap.Insert(12);
            minHeap.Insert(39);
            minHeap.Insert(33);
            minHeap.Insert(41);

            Console.WriteLine(minHeap.Values);

            Console.WriteLine(minHeap.ExtractMin());
            Console.WriteLine(minHeap.ExtractMin());
            Console.WriteLine(minHeap.ExtractMin());
            Console.WriteLine(minHeap.ExtractMin());
            Console.WriteLine(minHeap.ExtractMin());
            Console.WriteLine(minHeap.ExtractMin());

        }
    }
}
