using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapImplement_Array
{
    class Program
    {
        public void swap(int[] arr, int first, int second)
        {
            var auxiliary = arr[first];
            arr[first] = arr[second];
            arr[second] = auxiliary;
        }

        public int Compare(int[] arr, int left, int right, int root, int size)
        {
			var location = -1;
			if (left < size && arr[left] < arr[root])
			{
				if (right < size &&
					arr[right] < arr[left])
				{
					this.swap(arr, right, root);
					location = right;
				}
				else
				{
					this.swap(arr, left, root);
					location = left;
				}
			}
			else if (right < size &&
					 arr[right] < arr[root])
			{
				this.swap(arr, right, root);
				location = right;
			}
			return location;
		}

		public void heap(int[] arr, int size, int root)
		{
			var left = 2 * root + 1;
			var right = 2 * root + 2;
			var step = this.Compare(arr, left,
									right, root,
									size);
			if (step != -1)
			{
				// Need to convert into min heap
				this.heap(arr, size, step);
			}
		}

		public void minHeapImp(int[] arr, int size)
		{
			// Get middle of given array
			var i = ((int)(size / 2)) - 1;
			while (i >= 0)
			{
				this.heap(arr, size, i);
				i--;
			}
		}
		public void printData(int[] arr, int size)
		{
			var i = 0;
			while (i < size)
			{
				Console.Write("   " + arr[i]);
				i++;
			}
			Console.Write("\n");
		}

		static void Main(string[] args)
        {
			var task = new Program();

			int[] arr = {4 , 7 , 8 , 2 , 9 , 3 , 1 , 6 , 10};

			var size = arr.Length;

			Console.WriteLine("\n Before Elements ");

			task.printData(arr, size);
			task.minHeapImp(arr, size);

			Console.WriteLine("After Min Heap Elements ");
			task.printData(arr, size);
		}
    }
}